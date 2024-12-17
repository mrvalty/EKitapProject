$(document).ready(function () {
    homeKategoriListesi();
});

function homeKategoriListesi() {
    $.ajax({
        type: "GET",
        url: `/Kategori/KategoriListesi`,
        data: JSON.stringify
            ({

            }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        beforeSend: function () {

        },
        error: function (request, status, error) {
            console.error("Veri çekilirken hata oluştu:", error);
        },
        success: function (data) {

            var kategoriMenuItem = $('#menuItems');

            data.result.forEach(function (item) {
                var menuItem = `<a href="#" class="nav-item nav-link kategori-info" data-id="${item.kategoriID}">${item.kategoriAdi}</a>`;
                kategoriMenuItem.append(menuItem);
            })
        },
        complete: function () {
        }
    });

}

$(document).on('click', '.kategori-info', function (e) {
    e.preventDefault(); // Sayfa yenilenmesini engelle

    const kategoriId = $(this).data('id');
    $.ajax({
        type: "POST",
        url: `/Kategori/KategoriyeGoreKitapGetir/${kategoriId}`,
        data: JSON.stringify
            ({

            }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        beforeSend: function () {

        },
        error: function (request, status, error) {
            console.error("Veri çekilirken hata oluştu:", error);
        },
        success: function (data) {

            if (data.isCompleted) {
                window.location.href = '/Kategori/KategoriKitapListesi?kitaplar=' + encodeURIComponent(JSON.stringify(data.result));
            }

            //var kategoriMenuItem = $('#menuItems');

            //data.result.forEach(function (item) {
            //    var menuItem = `<a href="#" class="nav-item nav-link kategori-info" data-id="${item.kategoriID}">${item.kategoriAdi}</a>`;
            //    kategoriMenuItem.append(menuItem);
            //})
        },
        complete: function () {
        }
    });



    /*console.log(kategoriId);*/
})