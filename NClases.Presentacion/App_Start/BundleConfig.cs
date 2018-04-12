using System.Web;
using System.Web.Optimization;

namespace NClases.Presentacion
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /***************************************** STYLES ******************************************************************/
            bundles.Add(new StyleBundle("~/Stylesheets").Include(
                      "~/Resources/global/css/bootstrap.min.css",
                      "~/Resources/global/css/bootstrap-extend.min.css",
                      "~/Resources/assets/css/site.min.css"));

            bundles.Add(new StyleBundle("~/Plugins_CSS").Include(
                      "~/Resources/global/vendor/animsition/animsition.css",
                      "~/Resources/global/vendor/asscrollable/asScrollable.css",
                      "~/Resources/global/vendor/switchery/switchery.css",
                      "~/Resources/global/vendor/intro-js/introjs.css",
                      "~/Resources/global/vendor/slidepanel/slidePanel.css",
                      "~/Resources/global/vendor/flag-icon-css/flag-icon.css"));

            bundles.Add(new StyleBundle("~/Datatable_CSS").Include(
                    "~/Resources/global/vendor/datatables.net-bs4/dataTables.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-fixedheader-bs4/dataTables.fixedheader.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-fixedcolumns-bs4/dataTables.fixedcolumns.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-rowgroup-bs4/dataTables.rowgroup.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-scroller-bs4/dataTables.scroller.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-select-bs4/dataTables.select.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-responsive-bs4/dataTables.responsive.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-buttons-bs4/dataTables.buttons.bootstrap4.css",
                    "~/Resources/assets/examples/css/tables/datatable.css"));

            bundles.Add(new StyleBundle("~/Notificaciones_CSS").Include(
                     "~/Resources/global/vendor/plyr/plyr.css"));

            bundles.Add(new StyleBundle("~/Datatable_CSS").Include(
                     "~/Resources/global/vendor/select2/select2.css" ,
                     "~/Resources/global/vendor/bootstrap-tokenfield/bootstrap-tokenfield.css"  
                     "~/Resources/global/vendor/bootstrap-tagsinput/bootstrap-tagsinput.css" ,
                     "~/Resources/global/vendor/bootstrap-select/bootstrap-select.css" ,
                     "~/Resources/global/vendor/icheck/icheck.css" ,
                     "~/Resources/global/vendor/switchery/switchery.css" ,
                     "~/Resources/global/vendor/asrange/asRange.css" ,
                     "~/Resources/global/vendor/ionrangeslider/ionrangeslider.min.css" ,
                     "~/Resources/global/vendor/asspinner/asSpinner.css" ,
                     "~/Resources/global/vendor/clockpicker/clockpicker.css" ,
                     "~/Resources/global/vendor/ascolorpicker/asColorPicker.css" ,
                     "~/Resources/global/vendor/bootstrap-touchspin/bootstrap-touchspin.css" ,
                     "~/Resources/global/vendor/jquery-labelauty/jquery-labelauty.css" ,
                     "~/Resources/global/vendor/bootstrap-datepicker/bootstrap-datepicker.css" ,
                     "~/Resources/global/vendor/bootstrap-maxlength/bootstrap-maxlength.css" ,
                     "~/Resources/global/vendor/timepicker/jquery-timepicker.css" ,
                     "~/Resources/global/vendor/jquery-strength/jquery-strength.css" ,
                     "~/Resources/global/vendor/multi-select/multi-select.css" ,
                     "~/Resources/global/vendor/typeahead-js/typeahead.css" ,
                     "~/Resources/assets/examples/css/forms/advanced.css" ));

            bundles.Add(new StyleBundle("~/Datatable_CSS").Include(
                     "~/Resources/global/fonts/weather-icons/weather-icons.css" ,
                     "~/Resources/global/fonts/web-icons/web-icons.min.css" ,
                     "~/Resources/global/fonts/font-awesome/font-awesome.min.css" ,
                     "~/Resources/global/fonts/brand-icons/brand-icons.min.css" ));

            bundles.Add(new StyleBundle("~/Custom_CSS").Include(
                    "~/Resources/Custom/CSS/orange.css"));

            bundles.Add(new StyleBundle("~/Spinner_CSS").Include(
                    "~/Resources/Custom/CSS/Spinner/book_flat.css",
                    "~/Resources/Custom/CSS/Spinner/book_full.css"));
            
            /******************************************** JS **********************************************************/
            bundles.Add(new ScriptBundle("~/Core_JS").Include(
                    "~/Resources/global/vendor/babel-external-helpers/babel-external-helpers.js",
                    "~/Resources/global/vendor/jquery/jquery.js",
                    "~/Resources/global/vendor/popper-js/umd/popper.min.js",
                    "~/Resources/global/vendor/bootstrap/bootstrap.js",
                    "~/Resources/global/vendor/animsition/animsition.js",
                    "~/Resources/global/vendor/mousewheel/jquery.mousewheel.js",
                    "~/Resources/global/vendor/asscrollbar/jquery-asScrollbar.js",
                    "~/Resources/global/vendor/asscrollable/jquery-asScrollable.js",
                    "~/Resources/global/vendor/ashoverscroll/jquery-asHoverScroll.js"));

            bundles.Add(new ScriptBundle("~/Plugins_JS").Include(
                    "~/Resources/global/vendor/switchery/switchery.js" ,
                    "~/Resources/global/vendor/intro-js/intro.js" ,
                    "~/Resources/global/vendor/screenfull/screenfull.js" ,
                    "~/Resources/global/vendor/slidepanel/jquery-slidePanel.js"));

            bundles.Add(new ScriptBundle("~/Scripts_JS").Include(
                    "~/Resources/global/vendor/switchery/switchery.js",
                    "~/Resources/global/vendor/intro-js/intro.js",
                    "~/Resources/global/vendor/screenfull/screenfull.js",
                    "~/Resources/global/vendor/slidepanel/jquery-slidePanel.js"));

        }
    }
}
