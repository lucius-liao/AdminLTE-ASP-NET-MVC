Imports System.Web.Optimization

Public Module BundleConfig
    ' 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        Dim ltecomponents As String = "~/Scripts/adminlte/components/"
        Dim lteplugins As String = "~/Scripts/adminlte/plugins/"
        Dim lte As String = "~/Scripts/adminlte/"

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(ltecomponents + "jquery/dist/jquery.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/lib").Include(ltecomponents + "jquery-ui/jquery-ui.min.js") _
        .Include(ltecomponents + "bootstrap/dist/js/bootstrap.min.js") _
        .Include(ltecomponents + "raphael/raphael.min.js") _
        .Include(ltecomponents + "morris.js/morris.min.js") _
        .Include(ltecomponents + "chart.js/Chart.min.js") _
        .Include(ltecomponents + "Flot/jquery.flot.js") _
        .Include(ltecomponents + "Flot/jquery.flot.resize.js") _
        .Include(ltecomponents + "Flot/jquery.flot.pie.js") _
        .Include(ltecomponents + "Flot/jquery.flot.categories.js") _
        .Include(ltecomponents + "jquery-sparkline/dist/jquery.sparkline.min.js") _
        .Include(lteplugins + "jvectormap/jquery-jvectormap-1.2.2.min.js") _
        .Include(lteplugins + "jvectormap/jquery-jvectormap-world-mill-en.js") _
        .Include(ltecomponents + "jquery-knob/dist/jquery.knob.min.js") _
        .Include(ltecomponents + "moment/moment.js") _
        .Include(ltecomponents + "PACE/pace.min.js") _
        .Include(ltecomponents + "ckeditor/ckeditor.js") _
        .Include(ltecomponents + "datatables.net/js/jquery.dataTables.min.js") _
        .Include(ltecomponents + "datatables.net-bs/js/dataTables.bootstrap.min.js") _
        .Include(ltecomponents + "bootstrap-daterangepicker/daterangepicker.js") _
        .Include(ltecomponents + "bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js") _
        .Include(ltecomponents + "bootstrap-colorpicker/dist/js/bootstrap-colorpicker.min.js") _
        .Include(lteplugins + "bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js") _
        .Include(ltecomponents + "jquery-slimscroll/jquery.slimscroll.min.js") _
        .Include(ltecomponents + "fastclick/lib/fastclick.js") _
        .Include(lte + "js/adminlte.min.js") _
        .Include(lte + "js/demo.js") _
        .Include(lteplugins + "bootstrap-slider/bootstrap-slider.js") _
        .Include(ltecomponents + "select2/dist/js/select2.full.min.js") _
        .Include(lteplugins + "input-mask/jquery.inputmask.js") _
        .Include(lteplugins + "input-mask/jquery.inputmask.date.extensions.js") _
        .Include(lteplugins + "input-mask/jquery.inputmask.extensions.js") _
        .Include(lteplugins + "timepicker/bootstrap-timepicker.min.js") _
        .Include(lteplugins + "iCheck/icheck.min.js") _
        .Include(ltecomponents + "fullcalendar/dist/fullcalendar.min.js"))

        bundles.Add(New ScriptBundle("~/bundles/dashboard1") _
                .Include(lte + "js/pages/dashboard.js"))

        bundles.Add(New ScriptBundle("~/bundles/dashboard2") _
                .Include(lte + "js/pages/dashboard2.js"))

        bundles.Add(New StyleBundle("~/Content/css") _
                .Include("~/Content/bootstrap.css") _
        .Include(ltecomponents + "bootstrap/dist/css/bootstrap.min.css") _
        .Include(ltecomponents + "font-awesome/css/font-awesome.min.css") _
        .Include(ltecomponents + "Ionicons/css/ionicons.min.css") _
        .Include(ltecomponents + "datatables.net-bs/css/dataTables.bootstrap.min.css") _
        .Include("~/Content/adminlte/css/AdminLTE.min.css") _
        .Include("~/Content/adminlte/css/skins/_all-skins.min.css") _
        .Include(ltecomponents + "morris.js/morris.css") _
        .Include(ltecomponents + "jvectormap/jquery-jvectormap.css") _
        .Include(ltecomponents + "bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css") _
        .Include(ltecomponents + "bootstrap-daterangepicker/daterangepicker.css") _
        .Include(lteplugins + "bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css") _
        .Include(lteplugins + "bootstrap-slider/slider.css") _
        .Include(ltecomponents + "select2/dist/css/select2.min.css") _
        .Include(ltecomponents + "bootstrap-colorpicker/dist/css/bootstrap-colorpicker.min.css") _
        .Include(lteplugins + "timepicker/bootstrap-timepicker.min.css") _
        .Include(lteplugins + "iCheck/all.css") _
        .Include(lteplugins + "pace/pace.min.css") _
        .Include(ltecomponents + "fullcalendar/dist/fullcalendar.min.css"))

    End Sub
End Module

