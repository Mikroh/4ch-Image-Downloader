
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Table table1;
	
	private global::Gtk.FileChooserButton filechooserbutton;
	
	private global::Gtk.Label labelResult;
	
	private global::Gtk.Table table4;
	
	private global::Gtk.Button buttonSubmit;
	
	private global::Gtk.Entry entryUrl;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("4ch Image Downloader");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.DefaultWidth = 1216;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(1)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(12));
		this.table1.ColumnSpacing = ((uint)(6));
		this.table1.BorderWidth = ((uint)(15));
		// Container child table1.Gtk.Table+TableChild
		this.filechooserbutton = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Select a Folder"), ((global::Gtk.FileChooserAction)(2)));
		this.filechooserbutton.Name = "filechooserbutton";
		this.table1.Add (this.filechooserbutton);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.filechooserbutton]));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.labelResult = new global::Gtk.Label ();
		this.labelResult.Name = "labelResult";
		this.labelResult.WidthChars = 50;
		this.table1.Add (this.labelResult);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelResult]));
		w2.TopAttach = ((uint)(2));
		w2.BottomAttach = ((uint)(3));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.table4 = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
		this.table4.Name = "table4";
		this.table4.RowSpacing = ((uint)(6));
		this.table4.ColumnSpacing = ((uint)(10));
		// Container child table4.Gtk.Table+TableChild
		this.buttonSubmit = new global::Gtk.Button ();
		this.buttonSubmit.CanFocus = true;
		this.buttonSubmit.Name = "buttonSubmit";
		this.buttonSubmit.UseUnderline = true;
		this.buttonSubmit.Label = global::Mono.Unix.Catalog.GetString ("Submit!");
		this.table4.Add (this.buttonSubmit);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table4 [this.buttonSubmit]));
		w3.LeftAttach = ((uint)(1));
		w3.RightAttach = ((uint)(2));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.entryUrl = new global::Gtk.Entry ();
		this.entryUrl.TooltipMarkup = "Enter thread URL";
		this.entryUrl.CanFocus = true;
		this.entryUrl.Name = "entryUrl";
		this.entryUrl.Text = global::Mono.Unix.Catalog.GetString ("Enter thread URL");
		this.entryUrl.IsEditable = true;
		this.entryUrl.InvisibleChar = '•';
		this.table4.Add (this.entryUrl);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryUrl]));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		this.table1.Add (this.table4);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.table4]));
		w5.TopAttach = ((uint)(1));
		w5.BottomAttach = ((uint)(2));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		this.Add (this.table1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultHeight = 209;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonSubmit.Clicked += new global::System.EventHandler (this.OnButtonSubmitClicked);
	}
}
