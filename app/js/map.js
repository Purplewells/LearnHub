// Initialize the map
var map = L.map('map').setView([0, 0], 2); // Set default center and zoom level

// Add Mapbox tiles with custom style
L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token={accessToken}', {
    attribution: 'Map data &copy; <a href="https://www.mapbox.com/">Mapbox</a>',
    maxZoom: 18,
    id: 'mapbox://styles/pearcube/clpui4zdq01fj01r52t1j1ge6', // Replace with your Mapbox style ID
    accessToken: 'pk.eyJ1IjoicGVhcmN1YmUiLCJhIjoiY2xwdWZ0aXlkMGxjMzJpcXNwZ2N4N3VvdCJ9.4dm5JtBb56jIMsClAEhSaQ' // Replace with your Mapbox access token
}).addTo(map);

// Add search control
var searchControl = L.esri.Geocoding.geosearch({
    useMapBounds: false,
    providers: [
        L.esri.Geocoding.arcgisOnlineProvider(),
    ]
}).addTo(map);

// Optional: Add a marker for a default location
L.marker([0, 0]).addTo(map);

searchControl.on('results', function (data) {
    // Remove previous markers
    map.eachLayer(function (layer) {
        if (layer instanceof L.Marker) {
            layer.remove();
        }
    });

    // Add a marker for each result
    for (var i = 0; i < data.results.length; i++) {
        L.marker(data.results[i].latlng).addTo(map);
    }
});
