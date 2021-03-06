﻿using System.Web;
using System.Web.Optimization;

namespace NClases.Presentacion
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /***************************************** STYLES ******************************************************************/
            bundles.Add(new StyleBundle("~/bundles/Stylesheets").Include(
                      "~/Resources/global/css/bootstrap.min.css",
                      "~/Resources/global/css/bootstrap-extend.min.css",
                      "~/Resources/assets/css/site.min.css"));

            bundles.Add(new StyleBundle("~/bundles/Plugins_CSS").Include(
                      "~/Resources/global/vendor/animsition/animsition.css",
                      "~/Resources/global/vendor/asscrollable/asScrollable.css",
                      "~/Resources/global/vendor/switchery/switchery.css",
                      "~/Resources/global/vendor/intro-js/introjs.css",
                      "~/Resources/global/vendor/slidepanel/slidePanel.css",
                      "~/Resources/global/vendor/flag-icon-css/flag-icon.css"));

            bundles.Add(new StyleBundle("~/bundles/Datatable_CSS").Include(
                    "~/Resources/global/vendor/datatables.net-bs4/dataTables.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-fixedheader-bs4/dataTables.fixedheader.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-fixedcolumns-bs4/dataTables.fixedcolumns.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-rowgroup-bs4/dataTables.rowgroup.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-scroller-bs4/dataTables.scroller.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-select-bs4/dataTables.select.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-responsive-bs4/dataTables.responsive.bootstrap4.css",
                    "~/Resources/global/vendor/datatables.net-buttons-bs4/dataTables.buttons.bootstrap4.css",
                    "~/Resources/assets/examples/css/tables/datatable.css"));

            bundles.Add(new StyleBundle("~/bundles/Modales_CSS").Include(
                     "~/Resources/assets/examples/css/uikit/modals.css"));

            bundles.Add(new StyleBundle("~/bundles/Botones_CSS").Include(
                     "~/Resources/assets/examples/css/uikit/buttons.css"));

            bundles.Add(new StyleBundle("~/bundles/Tooltip_CSS").Include(
                    "~/Resources/global/vendor/webui-popover/webui-popover.css",
                    "~/Resources/global/vendor/toolbar/toolbar.css"));

            bundles.Add(new StyleBundle("~/bundles/Badges_CSS").Include(
                   "~/Resources/assets/examples/css/uikit/badges.css"));

            bundles.Add(new StyleBundle("~/bundles/Badges_CSS").Include(
                   "~/Resources/assets/examples/css/uikit/progress-bars.css"));

            bundles.Add(new StyleBundle("~/bundles/Barra_Progreso_CSS").Include(
                   "~/Resources/assets/examples/css/uikit/progress-bars.css"));

            bundles.Add(new StyleBundle("~/bundles/Notificaciones_CSS").Include(
                     "~/Resources/global/vendor/plyr/plyr.css"));

            bundles.Add(new StyleBundle("~/bundles/Form_Advance_CSS").Include(
                     "~/Resources/global/vendor/select2/select2.css",
                     "~/Resources/global/vendor/bootstrap-tokenfield/bootstrap-tokenfield.css",
                     "~/Resources/global/vendor/bootstrap-tagsinput/bootstrap-tagsinput.css",
                     "~/Resources/global/vendor/bootstrap-select/bootstrap-select.css",
                     "~/Resources/global/vendor/icheck/icheck.css",
                     "~/Resources/global/vendor/switchery/switchery.css",
                     "~/Resources/global/vendor/asrange/asRange.css",
                     "~/Resources/global/vendor/ionrangeslider/ionrangeslider.min.css",
                     "~/Resources/global/vendor/asspinner/asSpinner.css",
                     "~/Resources/global/vendor/clockpicker/clockpicker.css",
                     "~/Resources/global/vendor/ascolorpicker/asColorPicker.css",
                     "~/Resources/global/vendor/bootstrap-touchspin/bootstrap-touchspin.css",
                     "~/Resources/global/vendor/jquery-labelauty/jquery-labelauty.css",
                     "~/Resources/global/vendor/bootstrap-datepicker/bootstrap-datepicker.css",
                     "~/Resources/global/vendor/bootstrap-maxlength/bootstrap-maxlength.css",
                     "~/Resources/global/vendor/timepicker/jquery-timepicker.css",
                     "~/Resources/global/vendor/jquery-strength/jquery-strength.css",
                     "~/Resources/global/vendor/multi-select/multi-select.css",
                     "~/Resources/global/vendor/typeahead-js/typeahead.css",
                     "~/Resources/assets/examples/css/forms/advanced.css"));

            bundles.Add(new StyleBundle("~/bundles/Fonts_CSS").Include(
                     "~/Resources/global/fonts/weather-icons/weather-icons.css",
                     "~/Resources/global/fonts/web-icons/web-icons.min.css",
                     "~/Resources/global/fonts/font-awesome/font-awesome.min.css",
                     "~/Resources/global/fonts/brand-icons/brand-icons.min.css"));

            bundles.Add(new StyleBundle("~/bundles/Custom_CSS").Include(
                    "~/Resources/Custom/CSS/orange.css"));

            bundles.Add(new StyleBundle("~/bundles/Spinner_CSS").Include(
                    "~/Resources/Custom/CSS/Spinner/book_flat.css",
                    "~/Resources/Custom/CSS/Spinner/book_full.css"));

            /******************************************** JS **********************************************************/
            bundles.Add(new ScriptBundle("~/bundles/Core_JS").Include(
                    "~/Resources/global/vendor/babel-external-helpers/babel-external-helpers.js",
                    "~/Resources/global/vendor/jquery/jquery.js",
                    "~/Resources/global/vendor/popper-js/umd/popper.min.js",
                    "~/Resources/global/vendor/bootstrap/bootstrap.js",
                    "~/Resources/global/vendor/animsition/animsition.js",
                    "~/Resources/global/vendor/mousewheel/jquery.mousewheel.js",
                    "~/Resources/global/vendor/asscrollbar/jquery-asScrollbar.js",
                    "~/Resources/global/vendor/asscrollable/jquery-asScrollable.js",
                    "~/Resources/global/vendor/ashoverscroll/jquery-asHoverScroll.js"));

            bundles.Add(new ScriptBundle("~/bundles/Plugins_JS").Include(
                    "~/Resources/global/vendor/switchery/switchery.js",
                    "~/Resources/global/vendor/intro-js/intro.js",
                    "~/Resources/global/vendor/screenfull/screenfull.js",
                    "~/Resources/global/vendor/slidepanel/jquery-slidePanel.js"));

            bundles.Add(new ScriptBundle("~/bundles/Scripts_JS").Include(
                    "~/Resources/global/js/Component.js",
                    "~/Resources/global/js/Plugin.js",
                    "~/Resources/global/js/Base.js",
                    "~/Resources/global/js/Config.js",

                    "~/Resources/assets/js/Section/Menubar.js",
                    "~/Resources/assets/js/Section/GridMenu.js",
                    "~/Resources/assets/js/Section/Sidebar.js",
                    "~/Resources/assets/js/Section/PageAside.js",
                    "~/Resources/assets/js/Plugin/menu.js",

                    "~/Resources/global/js/config/colors.js",
                    "~/Resources/assets/js/config/tour.js"));


            bundles.Add(new ScriptBundle("~/bundles/Page_JS").Include(
                    "~/Resources/assets/js/Site.js",
                    "~/Resources/global/js/Plugin/asscrollable.js",
                    "~/Resources/global/js/Plugin/slidepanel.js",
                    "~/Resources/global/js/Plugin/switchery.js"));

            bundles.Add(new ScriptBundle("~/bundles/Page_JS").Include(
                     "~/Resources/global/vendor/datatables.net/jquery.dataTables.js",
                      "~/Resources/global/vendor/datatables.net-bs4/dataTables.bootstrap4.js",
                      "~/Resources/global/vendor/datatables.net-fixedheader/dataTables.fixedHeader.js",
                      "~/Resources/global/vendor/datatables.net-fixedcolumns/dataTables.fixedColumns.js",
                      "~/Resources/global/vendor/datatables.net-rowgroup/dataTables.rowGroup.js",
                      "~/Resources/global/vendor/datatables.net-scroller/dataTables.scroller.js",
                      "~/Resources/global/vendor/datatables.net-responsive/dataTables.responsive.js",
                      "~/Resources/global/vendor/datatables.net-responsive-bs4/responsive.bootstrap4.js",
                      "~/Resources/global/vendor/datatables.net-buttons/dataTables.buttons.js",
                      "~/Resources/global/vendor/datatables.net-buttons/buttons.html5.js",
                      "~/Resources/global/vendor/datatables.net-buttons/buttons.flash.js",
                      "~/Resources/global/vendor/datatables.net-buttons/buttons.print.js",
                      "~/Resources/global/vendor/datatables.net-buttons/buttons.colVis.js",
                      "~/Resources/global/vendor/datatables.net-buttons-bs4/buttons.bootstrap4.js",
                      "~/Resources/global/vendor/asrange/jquery-asRange.min.js",
                      "~/Resources/global/vendor/bootbox/bootbox.js"));

            bundles.Add(new ScriptBundle("~/bundles/Datatable_JS").Include(
                     "~/Resources/global/vendor/datatables.net/jquery.dataTables.js",
                      "~/Resources/global/vendor/datatables.net-bs4/dataTables.bootstrap4.js",
                      "~/Resources/global/vendor/datatables.net-fixedheader/dataTables.fixedHeader.js",
                      "~/Resources/global/vendor/datatables.net-fixedcolumns/dataTables.fixedColumns.js",
                      "~/Resources/global/vendor/datatables.net-rowgroup/dataTables.rowGroup.js",
                      "~/Resources/global/vendor/datatables.net-scroller/dataTables.scroller.js",
                      "~/Resources/global/vendor/datatables.net-responsive/dataTables.responsive.js",
                      "~/Resources/global/vendor/datatables.net-responsive-bs4/responsive.bootstrap4.js",
                      "~/Resources/global/vendor/datatables.net-buttons/dataTables.buttons.js",
                      "~/Resources/global/vendor/datatables.net-buttons/buttons.html5.js",
                      "~/Resources/global/vendor/datatables.net-buttons/buttons.flash.js",
                      "~/Resources/global/vendor/datatables.net-buttons/buttons.print.js",
                      "~/Resources/global/vendor/datatables.net-buttons/buttons.colVis.js",
                      "~/Resources/global/vendor/datatables.net-buttons-bs4/buttons.bootstrap4.js",
                      "~/Resources/global/vendor/asrange/jquery-asRange.min.js",
                      "~/Resources/global/vendor/bootbox/bootbox.js",
                      "~/Resources/global/js/Plugin/datatables.js"));

            bundles.Add(new ScriptBundle("~/bundles/Tooltip_JS").Include(
                      "~/Resources/global/vendor/webui-popover/jquery.webui-popover.min.js",
                      "~/Resources/global/vendor/toolbar/jquery.toolbar.js",
                      "~/Resources/global/js/Plugin/webui-popover.js",
                      "~/Resources/global/js/Plugin/toolbar.js",
                      "~/Resources/assets/examples/js/uikit/tooltip-popover.js"));

            bundles.Add(new ScriptBundle("~/bundles/Gallery_IMG_JS").Include(
                     "~/Resources/global/vendor/magnific-popup/jquery.magnific-popup.js",
                     "~/Resources/global/js/Plugin/magnific-popup.js",
                     "~/Resources/assets/examples/js/advanced/lightbox.js"));

            bundles.Add(new ScriptBundle("~/bundles/Timeline_JS").Include(
                    "~/Resources/global/vendor/jquery-appear/jquery.appear.js",
                    "~/Resources/global/vendor/plyr/plyr.js",
                    "~/Resources/global/js/Plugin/plyr.js",
                    "~/Resources/assets/examples/js/structure/timeline.js"));

            bundles.Add(new ScriptBundle("~/bundles/Forms_JS").Include(
                    "~/Resources/global/vendor/jquery-placeholder/jquery.placeholder.js",
                    "~/Resources/global/js/Plugin/jquery-placeholder.js",
                    "~/Resources/global/js/Plugin/input-group-file.js"));

            bundles.Add(new ScriptBundle("~/bundles/Forms_Advanced_JS").Include(
                    "~/Resources/global/vendor/select2/select2.full.min.js",
                  "~/Resources/global/vendor/bootstrap-tokenfield/bootstrap-tokenfield.min.js",
                  "~/Resources/global/vendor/bootstrap-tagsinput/bootstrap-tagsinput.min.js",
                  "~/Resources/global/vendor/bootstrap-select/bootstrap-select.js",
                  "~/Resources/global/vendor/icheck/icheck.min.js",
                  "~/Resources/global/vendor/switchery/switchery.js",
                  "~/Resources/global/vendor/asrange/jquery-asRange.min.js",
                  "~/Resources/global/vendor/ionrangeslider/ion.rangeSlider.min.js",
                  "~/Resources/global/vendor/asspinner/jquery-asSpinner.min.js",
                  "~/Resources/global/vendor/clockpicker/bootstrap-clockpicker.min.js",
                  "~/Resources/global/vendor/ascolor/jquery-asColor.min.js",
                  "~/Resources/global/vendor/asgradient/jquery-asGradient.min.js",
                  "~/Resources/global/vendor/ascolorpicker/jquery-asColorPicker.min.js",
                  "~/Resources/global/vendor/bootstrap-maxlength/bootstrap-maxlength.js",
                  "~/Resources/global/vendor/jquery-knob/jquery.knob.js",
                  "~/Resources/global/vendor/bootstrap-touchspin/bootstrap-touchspin.min.js",
                  "~/Resources/global/vendor/jquery-labelauty/jquery-labelauty.js",
                  "~/Resources/global/vendor/bootstrap-datepicker/bootstrap-datepicker.js",
                  "~/Resources/global/vendor/timepicker/jquery.timepicker.min.js",
                  "~/Resources/global/vendor/datepair/datepair.min.js",
                  "~/Resources/global/vendor/datepair/jquery.datepair.min.js",
                  "~/Resources/global/vendor/jquery-strength/password_strength.js",
                  "~/Resources/global/vendor/jquery-strength/jquery-strength.min.js",
                  "~/Resources/global/vendor/multi-select/jquery.multi-select.js",
                  "~/Resources/global/vendor/typeahead-js/bloodhound.min.js",
                  "~/Resources/global/vendor/typeahead-js/typeahead.jquery.min.js",
                  "~/Resources/global/vendor/jquery-placeholder/jquery.placeholder.js",
                  "~/Resources/global/js/Plugin/select2.js",
                  "~/Resources/global/js/Plugin/bootstrap-tokenfield.js",
                  "~/Resources/global/js/Plugin/bootstrap-tagsinput.js",
                  "~/Resources/global/js/Plugin/bootstrap-select.js",
                  "~/Resources/global/js/Plugin/icheck.js",
                  "~/Resources/global/js/Plugin/switchery.js",
                  "~/Resources/global/js/Plugin/asrange.js",
                  "~/Resources/global/js/Plugin/ionrangeslider.js",
                  "~/Resources/global/js/Plugin/asspinner.js",
                  "~/Resources/global/js/Plugin/clockpicker.js",
                  "~/Resources/global/js/Plugin/ascolorpicker.js",
                  "~/Resources/global/js/Plugin/bootstrap-maxlength.js",
                  "~/Resources/global/js/Plugin/jquery-knob.js",
                  "~/Resources/global/js/Plugin/bootstrap-touchspin.js",
                  "~/Resources/global/js/Plugin/card.js",
                  "~/Resources/global/js/Plugin/jquery-labelauty.js",
                  "~/Resources/global/js/Plugin/bootstrap-datepicker.js",
                  "~/Resources/global/js/Plugin/jt-timepicker.js",
                  "~/Resources/global/js/Plugin/datepair.js",
                  "~/Resources/global/js/Plugin/jquery-strength.js",
                  "~/Resources/global/js/Plugin/multi-select.js",
                  "~/Resources/global/js/Plugin/jquery-placeholder.js",
                  "~/Resources/assets/examples/js/forms/advanced.js"));

            bundles.Add(new ScriptBundle("~/bundles/Custom_JS").Include(
                    "~/Resources/Custom/JS/DataTableNTablaBasica.js",
                    "~/Resources/Custom/JS/DataTableCustom.js",
                    "~/Resources/Custom/JS/TOUR/Index-Tour.js")); 
        }
    }
}
