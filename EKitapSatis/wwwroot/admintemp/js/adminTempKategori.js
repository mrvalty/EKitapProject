$(document).ready(function () {
    $('#datatablesSimple tbody').on('click', '.sil-btn', function () {

        const id = $(this).data('id');

        Swal.fire({
            title: 'Silmek istediğinize emin misiniz?',
            text: 'Bu işlem geri alınamaz!',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet, sil!',
            cancelButtonText: 'İptal'
        }).then((result) => {
            if (result.isConfirmed) {

                $.ajax({
                    type: "DELETE",
                    url: `KategoriSil/${id}`,
                    data: JSON.stringify
                        ({
                            KategoriID: id
                        }),

                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    beforeSend: function () {

                    },
                    error: function (request, status, error) {
                        //Swal.fire(
                        //    'Hata!',
                        //    'Kaydınız silinirken bir hata oluştu.',
                        //    'error'
                        //);
                    },
                    success: function (msg) {

                    },
                    complete: function () {
                        Swal.fire(
                            'Silindi!',
                            'Kaydınız başarıyla silindi.',
                            'success'
                        ).then(() => {
                            window.location.href = 'KategoriListesi'; // Controller'daki "KitapListesi" action'ına yönlendirme
                        });
                    }
                });

            }
        });
    });
});