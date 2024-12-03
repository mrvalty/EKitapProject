function detay(id) {

    $.ajax({
        url: '/YonetimPanel/Kullanici/KullaniciDetay', // Doğru route'u kullanın
        type: 'GET',
        data: { id: id },
        success: function (data) {
            $('#modalTable tbody').empty();
            // Gelen verileri tabloya ekle
            data.forEach(res => {

                $('#modalTable tbody').append(`
                    <tr>
                        <td>${res.iletisimID}</td>
                        <td>${res.kullaniciAdi}</td>
                        <td>${res.adSoyad}</td>
                        <td>${res.eposta}</td>
                        <td>${res.telefon}</td>
                        <td>${res.il}</td>
                        <td>${res.ilce}</td>
                        <td>${res.adres}</td>
                    </tr>
                `);
            })

            $('#detayKullaniciModal').modal('show'); // Modal'ı aç
        },
        error: function () {
            alert('Bir hata oluştu!');
        }
    });

}