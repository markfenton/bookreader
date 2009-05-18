// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.UIManager UIManager;
    
    private Gtk.Action OpenFileAction;
    
    private Gtk.VBox vbox1;
    
    private Gtk.Toolbar toolbar1;
    
    private Gtk.ScrolledWindow GtkScrolledWindow;
    
    private Gtk.TextView booktextview;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.UIManager = new Gtk.UIManager();
        Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
        this.OpenFileAction = new Gtk.Action("OpenFileAction", Mono.Unix.Catalog.GetString("Open File"), null, "gtk-open");
        this.OpenFileAction.ShortLabel = Mono.Unix.Catalog.GetString("Open File");
        w1.Add(this.OpenFileAction, null);
        this.UIManager.InsertActionGroup(w1, 0);
        this.AddAccelGroup(this.UIManager.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("BookReader");
        this.Icon = Stetic.IconLoader.LoadIcon(this, "stock_book_blue", Gtk.IconSize.Menu, 16);
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><toolbar name='toolbar1'><toolitem name='OpenFileAction' action='OpenFileAction'/></toolbar></ui>");
        this.toolbar1 = ((Gtk.Toolbar)(this.UIManager.GetWidget("/toolbar1")));
        this.toolbar1.Name = "toolbar1";
        this.toolbar1.ShowArrow = false;
        this.toolbar1.ToolbarStyle = ((Gtk.ToolbarStyle)(0));
        this.toolbar1.IconSize = ((Gtk.IconSize)(3));
        this.vbox1.Add(this.toolbar1);
        Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.toolbar1]));
        w2.Position = 0;
        w2.Expand = false;
        w2.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.GtkScrolledWindow = new Gtk.ScrolledWindow();
        this.GtkScrolledWindow.Name = "GtkScrolledWindow";
        this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
        // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
        this.booktextview = new Gtk.TextView();
        this.booktextview.CanFocus = true;
        this.booktextview.Name = "booktextview";
        this.booktextview.Editable = false;
        this.booktextview.CursorVisible = false;
        this.booktextview.WrapMode = ((Gtk.WrapMode)(2));
        this.booktextview.LeftMargin = 2;
        this.booktextview.RightMargin = 2;
        this.GtkScrolledWindow.Add(this.booktextview);
        this.vbox1.Add(this.GtkScrolledWindow);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
        w4.Position = 1;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 446;
        this.DefaultHeight = 368;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.OpenFileAction.Activated += new System.EventHandler(this.OnOpenFileActionActivated);
    }
}
