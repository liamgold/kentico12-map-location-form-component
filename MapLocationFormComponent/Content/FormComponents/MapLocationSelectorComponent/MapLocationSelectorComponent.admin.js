function createMapSelector(mapId, latitudeId, latitudeValue, longitudeId, longitudeValue, iconUrl, shadowUrl) {
    var mymap = L.map(mapId).setView([latitudeValue, longitudeValue], 5);

    var mapIcon = L.icon({
        iconUrl: iconUrl,
        shadowUrl: shadowUrl,
        iconSize: [25, 41],
        shadowSize: [41, 41],
        iconAnchor: [12, 41],
        shadowAnchor: [20, 41],
    });

    var marker = L.marker([latitudeValue, longitudeValue], { icon: mapIcon }).addTo(mymap);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(mymap);

    function onMapClick(e) {
        marker.setLatLng(e.latlng);

        var hdnLatitude = document.getElementById(latitudeId);
        hdnLatitude.value = e.latlng.lat;

        var hdnLongitude = document.getElementById(longitudeId);
        hdnLongitude.value = e.latlng.lng;
    }

    mymap.on('click', onMapClick);
}