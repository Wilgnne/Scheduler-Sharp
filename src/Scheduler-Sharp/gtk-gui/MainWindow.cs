
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Notebook notebook1;

	private global::Gtk.VBox simulatorBox;

	private global::Gtk.HBox menuBox;

	private global::Gtk.ComboBox SchedulerCombobox;

	private global::Gtk.ComboBoxEntry directoryEntry;

	private global::Gtk.Button SearchButton;

	private global::Gtk.HButtonBox hbuttonbox1;

	private global::Gtk.VBox plotBox;

	private global::Gtk.HBox mediaBox;

	private global::Gtk.Button previewButton;

	private global::Gtk.Button pauseButton;

	private global::Gtk.Button playButton;

	private global::Gtk.Button nextButton;

	private global::Gtk.Label simuPageText;

	private global::Gtk.VBox creatorBox;

	private global::Gtk.HBox cMenuBox;

	private global::Gtk.ComboBox dirCreatorEntry;

	private global::Gtk.Button saveCreatorButton;

	private global::Gtk.Button editCreatorButton;

	private global::Gtk.ScrolledWindow scrolledWindow;

	private global::Gtk.HBox settingsBox;

	private global::Gtk.Button addCreatorButton;

	private global::Gtk.Button removeCreatorButton;

	private global::Gtk.Label creationPageText;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Scherduler-Sharp");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource("SchedulerSharp.004-01-512.png");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.notebook1 = new global::Gtk.Notebook();
		this.notebook1.CanFocus = true;
		this.notebook1.Name = "notebook1";
		this.notebook1.CurrentPage = 1;
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.simulatorBox = new global::Gtk.VBox();
		this.simulatorBox.Name = "simulatorBox";
		this.simulatorBox.Spacing = 6;
		// Container child simulatorBox.Gtk.Box+BoxChild
		this.menuBox = new global::Gtk.HBox();
		this.menuBox.Name = "menuBox";
		this.menuBox.Spacing = 6;
		// Container child menuBox.Gtk.Box+BoxChild
		this.SchedulerCombobox = global::Gtk.ComboBox.NewText();
		this.SchedulerCombobox.AppendText(global::Mono.Unix.Catalog.GetString("Escalonador X"));
		this.SchedulerCombobox.AppendText(global::Mono.Unix.Catalog.GetString("Escalonador Y"));
		this.SchedulerCombobox.AppendText(global::Mono.Unix.Catalog.GetString("Escalonador Z"));
		this.SchedulerCombobox.WidthRequest = 160;
		this.SchedulerCombobox.Name = "SchedulerCombobox";
		this.SchedulerCombobox.Active = 0;
		this.menuBox.Add(this.SchedulerCombobox);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.menuBox[this.SchedulerCombobox]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child menuBox.Gtk.Box+BoxChild
		this.directoryEntry = global::Gtk.ComboBoxEntry.NewText();
		this.directoryEntry.Name = "directoryEntry";
		this.menuBox.Add(this.directoryEntry);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.menuBox[this.directoryEntry]));
		w2.Position = 1;
		// Container child menuBox.Gtk.Box+BoxChild
		this.SearchButton = new global::Gtk.Button();
		this.SearchButton.CanFocus = true;
		this.SearchButton.Name = "SearchButton";
		this.SearchButton.UseUnderline = true;
		this.SearchButton.Label = global::Mono.Unix.Catalog.GetString("Procurar");
		global::Gtk.Image w3 = new global::Gtk.Image();
		w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-file", global::Gtk.IconSize.Button);
		this.SearchButton.Image = w3;
		this.menuBox.Add(this.SearchButton);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.menuBox[this.SearchButton]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.simulatorBox.Add(this.menuBox);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.simulatorBox[this.menuBox]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child simulatorBox.Gtk.Box+BoxChild
		this.hbuttonbox1 = new global::Gtk.HButtonBox();
		this.hbuttonbox1.Name = "hbuttonbox1";
		this.simulatorBox.Add(this.hbuttonbox1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.simulatorBox[this.hbuttonbox1]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child simulatorBox.Gtk.Box+BoxChild
		this.plotBox = new global::Gtk.VBox();
		this.plotBox.Name = "plotBox";
		this.simulatorBox.Add(this.plotBox);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.simulatorBox[this.plotBox]));
		w7.Position = 2;
		// Container child simulatorBox.Gtk.Box+BoxChild
		this.mediaBox = new global::Gtk.HBox();
		this.mediaBox.Name = "mediaBox";
		this.mediaBox.Spacing = 6;
		// Container child mediaBox.Gtk.Box+BoxChild
		this.previewButton = new global::Gtk.Button();
		this.previewButton.CanFocus = true;
		this.previewButton.Name = "previewButton";
		this.previewButton.UseUnderline = true;
		this.previewButton.Label = global::Mono.Unix.Catalog.GetString("Retroceder");
		global::Gtk.Image w8 = new global::Gtk.Image();
		w8.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-media-previous", global::Gtk.IconSize.Button);
		this.previewButton.Image = w8;
		this.mediaBox.Add(this.previewButton);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.mediaBox[this.previewButton]));
		w9.Position = 0;
		// Container child mediaBox.Gtk.Box+BoxChild
		this.pauseButton = new global::Gtk.Button();
		this.pauseButton.CanFocus = true;
		this.pauseButton.Name = "pauseButton";
		this.pauseButton.UseUnderline = true;
		this.pauseButton.Label = global::Mono.Unix.Catalog.GetString("Pausa");
		global::Gtk.Image w10 = new global::Gtk.Image();
		w10.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-media-pause", global::Gtk.IconSize.Button);
		this.pauseButton.Image = w10;
		this.mediaBox.Add(this.pauseButton);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.mediaBox[this.pauseButton]));
		w11.Position = 1;
		// Container child mediaBox.Gtk.Box+BoxChild
		this.playButton = new global::Gtk.Button();
		this.playButton.CanFocus = true;
		this.playButton.Name = "playButton";
		this.playButton.UseUnderline = true;
		this.playButton.Label = global::Mono.Unix.Catalog.GetString("Iniciar");
		global::Gtk.Image w12 = new global::Gtk.Image();
		w12.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-media-play", global::Gtk.IconSize.Button);
		this.playButton.Image = w12;
		this.mediaBox.Add(this.playButton);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.mediaBox[this.playButton]));
		w13.Position = 2;
		// Container child mediaBox.Gtk.Box+BoxChild
		this.nextButton = new global::Gtk.Button();
		this.nextButton.CanFocus = true;
		this.nextButton.Name = "nextButton";
		this.nextButton.UseUnderline = true;
		this.nextButton.Label = global::Mono.Unix.Catalog.GetString("Avançar");
		global::Gtk.Image w14 = new global::Gtk.Image();
		w14.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-media-next", global::Gtk.IconSize.Button);
		this.nextButton.Image = w14;
		this.mediaBox.Add(this.nextButton);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.mediaBox[this.nextButton]));
		w15.Position = 3;
		this.simulatorBox.Add(this.mediaBox);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.simulatorBox[this.mediaBox]));
		w16.Position = 3;
		w16.Expand = false;
		w16.Fill = false;
		this.notebook1.Add(this.simulatorBox);
		// Notebook tab
		this.simuPageText = new global::Gtk.Label();
		this.simuPageText.Name = "simuPageText";
		this.simuPageText.LabelProp = global::Mono.Unix.Catalog.GetString("Simulação");
		this.notebook1.SetTabLabel(this.simulatorBox, this.simuPageText);
		this.simuPageText.ShowAll();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.creatorBox = new global::Gtk.VBox();
		this.creatorBox.Name = "creatorBox";
		this.creatorBox.Spacing = 6;
		// Container child creatorBox.Gtk.Box+BoxChild
		this.cMenuBox = new global::Gtk.HBox();
		this.cMenuBox.Name = "cMenuBox";
		this.cMenuBox.Spacing = 6;
		// Container child cMenuBox.Gtk.Box+BoxChild
		this.dirCreatorEntry = global::Gtk.ComboBox.NewText();
		this.dirCreatorEntry.Name = "dirCreatorEntry";
		this.cMenuBox.Add(this.dirCreatorEntry);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.cMenuBox[this.dirCreatorEntry]));
		w18.Position = 0;
		// Container child cMenuBox.Gtk.Box+BoxChild
		this.saveCreatorButton = new global::Gtk.Button();
		this.saveCreatorButton.CanFocus = true;
		this.saveCreatorButton.Name = "saveCreatorButton";
		this.saveCreatorButton.UseUnderline = true;
		this.saveCreatorButton.Label = "_OK";
		global::Gtk.Image w19 = new global::Gtk.Image();
		w19.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Button);
		this.saveCreatorButton.Image = w19;
		this.cMenuBox.Add(this.saveCreatorButton);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.cMenuBox[this.saveCreatorButton]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		// Container child cMenuBox.Gtk.Box+BoxChild
		this.editCreatorButton = new global::Gtk.Button();
		this.editCreatorButton.CanFocus = true;
		this.editCreatorButton.Name = "editCreatorButton";
		this.editCreatorButton.UseUnderline = true;
		this.editCreatorButton.Label = global::Mono.Unix.Catalog.GetString("Editar");
		global::Gtk.Image w21 = new global::Gtk.Image();
		w21.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-edit", global::Gtk.IconSize.Menu);
		this.editCreatorButton.Image = w21;
		this.cMenuBox.Add(this.editCreatorButton);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.cMenuBox[this.editCreatorButton]));
		w22.Position = 2;
		w22.Expand = false;
		w22.Fill = false;
		this.creatorBox.Add(this.cMenuBox);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.creatorBox[this.cMenuBox]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child creatorBox.Gtk.Box+BoxChild
		this.scrolledWindow = new global::Gtk.ScrolledWindow();
		this.scrolledWindow.CanFocus = true;
		this.scrolledWindow.Name = "scrolledWindow";
		this.scrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		this.creatorBox.Add(this.scrolledWindow);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.creatorBox[this.scrolledWindow]));
		w24.Position = 1;
		// Container child creatorBox.Gtk.Box+BoxChild
		this.settingsBox = new global::Gtk.HBox();
		this.settingsBox.Name = "settingsBox";
		this.settingsBox.Spacing = 6;
		// Container child settingsBox.Gtk.Box+BoxChild
		this.addCreatorButton = new global::Gtk.Button();
		this.addCreatorButton.CanFocus = true;
		this.addCreatorButton.Name = "addCreatorButton";
		this.addCreatorButton.UseUnderline = true;
		this.addCreatorButton.Label = global::Mono.Unix.Catalog.GetString("Adicionar");
		global::Gtk.Image w25 = new global::Gtk.Image();
		w25.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Button);
		this.addCreatorButton.Image = w25;
		this.settingsBox.Add(this.addCreatorButton);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.settingsBox[this.addCreatorButton]));
		w26.Position = 0;
		// Container child settingsBox.Gtk.Box+BoxChild
		this.removeCreatorButton = new global::Gtk.Button();
		this.removeCreatorButton.CanFocus = true;
		this.removeCreatorButton.Name = "removeCreatorButton";
		this.removeCreatorButton.UseUnderline = true;
		this.removeCreatorButton.Label = global::Mono.Unix.Catalog.GetString("Remover");
		global::Gtk.Image w27 = new global::Gtk.Image();
		w27.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "stock_delete", global::Gtk.IconSize.Button);
		this.removeCreatorButton.Image = w27;
		this.settingsBox.Add(this.removeCreatorButton);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.settingsBox[this.removeCreatorButton]));
		w28.Position = 1;
		this.creatorBox.Add(this.settingsBox);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.creatorBox[this.settingsBox]));
		w29.Position = 2;
		w29.Expand = false;
		w29.Fill = false;
		this.notebook1.Add(this.creatorBox);
		global::Gtk.Notebook.NotebookChild w30 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.creatorBox]));
		w30.Position = 1;
		// Notebook tab
		this.creationPageText = new global::Gtk.Label();
		this.creationPageText.Name = "creationPageText";
		this.creationPageText.LabelProp = global::Mono.Unix.Catalog.GetString("Criação");
		this.notebook1.SetTabLabel(this.creatorBox, this.creationPageText);
		this.creationPageText.ShowAll();
		this.Add(this.notebook1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 672;
		this.DefaultHeight = 488;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.dirCreatorEntry.Changed += new global::System.EventHandler(this.OnChangeDirEntry);
		this.saveCreatorButton.Clicked += new global::System.EventHandler(this.SaveButtonEvent);
		this.editCreatorButton.Clicked += new global::System.EventHandler(this.EditButtonEvent);
		this.addCreatorButton.Clicked += new global::System.EventHandler(this.AddCreationEvent);
		this.removeCreatorButton.Clicked += new global::System.EventHandler(this.RemoveCreationEvent);
	}
}
