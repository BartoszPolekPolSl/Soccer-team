#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB5301573D05F2CD9FD83CF02B68B4B6F9A69E2B6A0DB14F0B8166109A07EC5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Players.Properties;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Players {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_fName;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_lName;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_age;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sd_weight;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_weight;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_height;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_add;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_delete;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_modify;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_sort;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lb_players;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_ChangeLan;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_changeLangVersion;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Players;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\MainWindow.xaml"
            ((Players.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tb_fName = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.tb_fName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_fName_TextChanged);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MainWindow.xaml"
            this.tb_fName.GotFocus += new System.Windows.RoutedEventHandler(this.tb_fName_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb_lName = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\MainWindow.xaml"
            this.tb_lName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_lName_TextChanged);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            this.tb_lName.GotFocus += new System.Windows.RoutedEventHandler(this.tb_lName_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cb_age = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.sd_weight = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.tb_weight = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.tb_height = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\MainWindow.xaml"
            this.tb_height.GotFocus += new System.Windows.RoutedEventHandler(this.tb_height_GotFocus);
            
            #line default
            #line hidden
            
            #line 77 "..\..\MainWindow.xaml"
            this.tb_height.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tb_height_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.bt_add = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\MainWindow.xaml"
            this.bt_add.Click += new System.Windows.RoutedEventHandler(this.bt_add_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.bt_delete = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\MainWindow.xaml"
            this.bt_delete.Click += new System.Windows.RoutedEventHandler(this.bt_delete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.bt_modify = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\MainWindow.xaml"
            this.bt_modify.Click += new System.Windows.RoutedEventHandler(this.bt_modify_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.bt_sort = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\MainWindow.xaml"
            this.bt_sort.Click += new System.Windows.RoutedEventHandler(this.bt_sort_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lb_players = ((System.Windows.Controls.ListBox)(target));
            
            #line 101 "..\..\MainWindow.xaml"
            this.lb_players.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lb_players_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.cb_ChangeLan = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 14:
            this.bt_changeLangVersion = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\MainWindow.xaml"
            this.bt_changeLangVersion.Click += new System.Windows.RoutedEventHandler(this.bt_changeLangVersion_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

