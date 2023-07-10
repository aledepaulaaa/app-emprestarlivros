$(document).ready(function () {

    $('#emprestimos').DataTable({
        language:
            {
            "decimal": "",
            "emptyTable": "Não há dados disponíveis na tabela.",
            "info": "Mostrando _START_ registro de _END_ em um total _TOTAL_ entradas",
            "infoEmpty": "Mostrando 0 de 0 de 0 entradas",
            "infoFiltered": "(filtrado de _MAX_ entradas no total)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ entradas",
            "loadingRecords": "Carregando...",
            "processing": "",
            "search": "Procurar:",
            "zeroRecords": "Nenhum registro correspondente encontrado",
            "paginate": {
                "first": "Primeiro",
                "last": "Último",
                "next": "Próximo",
                "previous": "Anterior"
            },
                "aria": {
                    "sortAscending": ": activate to sort column ascending",
                    "sortDescending": ": activate to sort column descending"
                }
            }
    });

    setTimeout(() => {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        })
    }, 2000)
});