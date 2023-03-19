$(document).ready(function () {
    $(function () {
        $("#ik-table").DataTable({
            "responsive": true, "lengthChange": false, "autoWidth": false,
            "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
        }).buttons().container().appendTo('#ik-table_wrapper .col-md-6:eq(0)');

    });

    $(function () {
        $("#section-table").DataTable({
            "responsive": true, "lengthChange": false, "autoWidth": false,
            "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
        }).buttons().container().appendTo('#ik-table_wrapper .col-md-6:eq(0)');

    });

    $(function () {
        $("#section-table-vardiya").DataTable({
            "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "scrollY": "550px",
            "scrollCollapse": true,
            "paging": false,
            "buttons": []
        }).buttons().container().appendTo('#example1-shift_wrapper .col-md-6:eq(0)');

    });

    $('#section-table-vardiya tr').click(function (event) {
        if (event.target.type !== 'checkbox') {
            $(':checkbox', this).trigger('click');
        }
    });

    //HIDDEN INPUT ADDED SHIFT ID
    $('#radio-buttons-vardiya input').on('change', function () {
        var RadioBtnValue = $('input[name=options]:checked', '#radio-buttons-vardiya').val();
        $('#shiftidvardiya').attr('value', RadioBtnValue);
        alert(RadioBtnValue);

    });








});
