// Function to initialize the Google Map
function initMap() {
    // Set initial map options
    var map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 5.5560, lng: -0.1969 }, // Centered on San Francisco
        zoom: 3 // Zoom level to show broader view
    });

    // Fetch all orders from the CodeOnTime API
    $app.execute({
        controller: 'Orders',
        pageSize: 1000, // Fetch up to 1000 records
        filter: [], // No filter to retrieve all orders
        done: function (result) {
            var orders = result.data;
            var markers = [];

            // Iterate over the orders to create markers
            orders.forEach(function (order) {
                // Assuming your 'order' object has 'Latitude' and 'Longitude' fields
                var lat = order.Latitude; // Replace with the actual field name for latitude
                var lng = order.Longitude; // Replace with the actual field name for longitude

                // Check if coordinates are valid
                if (lat && lng) {
                    // Create a marker for each order
                    var marker = new google.maps.Marker({
                        position: { lat: lat, lng: lng },
                        title: 'Order ID: ' + order.OrderID // Set a title for the marker
                    });

                    // Add each marker to the markers array
                    markers.push(marker);

                    // Create an info window with order details
                    var infoWindow = new google.maps.InfoWindow({
                        content: `<b>Order ID:</b> ${order.OrderID}<br><b>Ship Country:</b> ${order.ShipCountry}`
                    });

                    // Add click listener to open info window when marker is clicked
                    marker.addListener('click', function () {
                        infoWindow.open(map, marker);
                    });
                }
            });

            // Use MarkerClusterer to manage and display markers efficiently
            new MarkerClusterer(map, markers, {
                imagePath: 'https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m'
            });
        },
        error: function (error) {
            // Handle any errors that occur during the API call
            console.error('Error fetching data:', error);
        }
    });
}

// Initialize the map once the window has loaded
window.onload = initMap;
