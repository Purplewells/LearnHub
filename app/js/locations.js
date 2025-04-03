function loadMap() {
    const mapElement = document.getElementById('map');
    if (!mapElement) {
        console.error("Map element not found");
        return;
    }

    const map = new google.maps.Map(mapElement, {
        zoom: 12,
        center: { lat: 6.5244, lng: 3.3792 } // Default to Lagos
    });

    fetch('/appservices/Assets') // Replace with actual API/View URL
        .then(response => response.json())
        .then(data => {
            data.forEach(asset => {
                const marker = new google.maps.Marker({
                    position: { lat: parseFloat(asset.Latitude), lng: parseFloat(asset.Longitude) },
                    map: map,
                    title: asset.Name
                });

                const infoWindow = new google.maps.InfoWindow({
                    content: `<strong>${asset.Name}</strong><br>Latitude: ${asset.Latitude}<br>Longitude: ${asset.Longitude}`
                });

                marker.addListener("click", function () {
                    infoWindow.open(map, marker);
                });
            });
        })
        .catch(error => {
            console.error("Error fetching asset data:", error);
            // Optionally, display an error message to the user
        });
}