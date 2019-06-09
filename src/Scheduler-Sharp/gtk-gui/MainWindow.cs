
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action dndAction;

	private global::Gtk.Action newAction;

	private global::Gtk.Action editAction;

	private global::Gtk.Action saveAction;

	private global::Gtk.Action saveAsAction;

	private global::Gtk.Action mediaPlayAction;

	private global::Gtk.Action directoryAction;

	private global::Gtk.Action PNGAction;

	private global::Gtk.Action SVGAction;

	private global::Gtk.Action LogLogAction;

	private global::Gtk.Action closeAction;

	private global::Gtk.Action LogTxtAction;

	private global::Gtk.Action orientationPortraitAction;

	private global::Gtk.Action LogLogAction1;

	private global::Gtk.Action CompatibilidadeAction;

	private global::Gtk.Action TxtParaJsonAction;

	private global::Gtk.Action findAndReplaceAction;

	private global::Gtk.Action convertAction;

	private global::Gtk.Action FCFSAction;

	private global::Gtk.Action PNGAction1;

	private global::Gtk.Action SVGAction1;

	private global::Gtk.Action FCFSAction1;

	private global::Gtk.Action SJFAction;

	private global::Gtk.Action RRAction;

	private global::Gtk.Action PNGAction2;

	private global::Gtk.Action SVGAction2;

	private global::Gtk.Action PNGAction3;

	private global::Gtk.Action SVGAction3;

	private global::Gtk.Action PNGAction4;

	private global::Gtk.Action SVGAction4;

	private global::Gtk.Action TodosAction;

	private global::Gtk.Action PNGAction5;

	private global::Gtk.Action SVGAction5;

	private global::Gtk.Action ComparaoAction;

	private global::Gtk.Action PNGAction6;

	private global::Gtk.Action SVGAction6;

	private global::Gtk.Action AjudaAction;

	private global::Gtk.Action SobreAction;

	private global::Gtk.VBox vbox1;

	private global::Gtk.MenuBar menubar3;

	private global::Gtk.Notebook notebook1;

	private global::Gtk.VBox simulatorBox;

	private global::Gtk.HBox menuBox;

	private global::Gtk.ComboBox SchedulerCombobox;

	private global::Gtk.ComboBox directoryEntry;

	private global::Gtk.HBox quantumBox;

	private global::Gtk.Label label1;

	private global::Gtk.HScale quantumScale;

	private global::Gtk.HPaned plotBox;

	private global::Gtk.HBox mediaBox;

	private global::Gtk.Button previewButton;

	private global::Gtk.Button pauseButton;

	private global::Gtk.Button playButton;

	private global::Gtk.Button nextButton;

	private global::Gtk.HBox hbox1;

	private global::Gtk.ProgressBar progressFCFS;

	private global::Gtk.ProgressBar progressSJF;

	private global::Gtk.ProgressBar progressRR;

	private global::Gtk.Label simuPageText;

	private global::Gtk.VBox creatorBox;

	private global::Gtk.HBox cMenuBox;

	private global::Gtk.ComboBox dirCreatorEntry;

	private global::Gtk.ScrolledWindow scrolledWindow;

	private global::Gtk.HBox settingsBox;

	private global::Gtk.Button addCreatorButton;

	private global::Gtk.Button removeCreatorButton;

	private global::Gtk.Label creationPageText;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.dndAction = new global::Gtk.Action("dndAction", global::Mono.Unix.Catalog.GetString("Arquivo"), null, "gtk-dnd");
		this.dndAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Arquivo");
		w1.Add(this.dndAction, null);
		this.newAction = new global::Gtk.Action("newAction", global::Mono.Unix.Catalog.GetString("Novo Arquivo"), null, "gtk-new");
		this.newAction.ShortLabel = global::Mono.Unix.Catalog.GetString("New");
		w1.Add(this.newAction, null);
		this.editAction = new global::Gtk.Action("editAction", global::Mono.Unix.Catalog.GetString("Abrir..."), null, "gtk-edit");
		this.editAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Open");
		w1.Add(this.editAction, null);
		this.saveAction = new global::Gtk.Action("saveAction", global::Mono.Unix.Catalog.GetString("Salvar"), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save");
		w1.Add(this.saveAction, null);
		this.saveAsAction = new global::Gtk.Action("saveAsAction", global::Mono.Unix.Catalog.GetString("Salvar Como..."), null, "gtk-save-as");
		this.saveAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save as");
		w1.Add(this.saveAsAction, null);
		this.mediaPlayAction = new global::Gtk.Action("mediaPlayAction", global::Mono.Unix.Catalog.GetString("Simulação"), null, "gtk-media-play");
		this.mediaPlayAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Simulação");
		w1.Add(this.mediaPlayAction, null);
		this.directoryAction = new global::Gtk.Action("directoryAction", global::Mono.Unix.Catalog.GetString("Exportar"), null, "gtk-directory");
		this.directoryAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Exportar");
		w1.Add(this.directoryAction, null);
		this.PNGAction = new global::Gtk.Action("PNGAction", global::Mono.Unix.Catalog.GetString(".PNG"), null, null);
		this.PNGAction.ShortLabel = global::Mono.Unix.Catalog.GetString(".PNG");
		w1.Add(this.PNGAction, null);
		this.SVGAction = new global::Gtk.Action("SVGAction", global::Mono.Unix.Catalog.GetString(".SVG"), null, null);
		this.SVGAction.ShortLabel = global::Mono.Unix.Catalog.GetString(".SVG");
		w1.Add(this.SVGAction, null);
		this.LogLogAction = new global::Gtk.Action("LogLogAction", global::Mono.Unix.Catalog.GetString("Log: .log"), null, null);
		this.LogLogAction.ShortLabel = global::Mono.Unix.Catalog.GetString(".json");
		w1.Add(this.LogLogAction, null);
		this.closeAction = new global::Gtk.Action("closeAction", global::Mono.Unix.Catalog.GetString("Fechar"), null, "gtk-close");
		this.closeAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Fechar");
		w1.Add(this.closeAction, null);
		this.LogTxtAction = new global::Gtk.Action("LogTxtAction", global::Mono.Unix.Catalog.GetString("Log: .txt"), null, null);
		this.LogTxtAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Log .txt");
		w1.Add(this.LogTxtAction, null);
		this.orientationPortraitAction = new global::Gtk.Action("orientationPortraitAction", global::Mono.Unix.Catalog.GetString("Importar"), null, "gtk-orientation-portrait");
		this.orientationPortraitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Importar");
		w1.Add(this.orientationPortraitAction, null);
		this.LogLogAction1 = new global::Gtk.Action("LogLogAction1", global::Mono.Unix.Catalog.GetString("Log: .log"), null, null);
		this.LogLogAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Log .json");
		w1.Add(this.LogLogAction1, null);
		this.CompatibilidadeAction = new global::Gtk.Action("CompatibilidadeAction", global::Mono.Unix.Catalog.GetString("Compatibilidade"), null, null);
		this.CompatibilidadeAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Compatibilidade");
		w1.Add(this.CompatibilidadeAction, null);
		this.TxtParaJsonAction = new global::Gtk.Action("TxtParaJsonAction", global::Mono.Unix.Catalog.GetString(".txt para .json"), null, null);
		this.TxtParaJsonAction.ShortLabel = global::Mono.Unix.Catalog.GetString(".txt para .json");
		w1.Add(this.TxtParaJsonAction, null);
		this.findAndReplaceAction = new global::Gtk.Action("findAndReplaceAction", global::Mono.Unix.Catalog.GetString("Compatibilidade"), null, "gtk-find-and-replace");
		this.findAndReplaceAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Compatibilidade");
		w1.Add(this.findAndReplaceAction, null);
		this.convertAction = new global::Gtk.Action("convertAction", global::Mono.Unix.Catalog.GetString("TXT para PRB"), null, "gtk-convert");
		this.convertAction.ShortLabel = global::Mono.Unix.Catalog.GetString("TXT para PRB");
		w1.Add(this.convertAction, null);
		this.FCFSAction = new global::Gtk.Action("FCFSAction", global::Mono.Unix.Catalog.GetString("FCFS"), null, null);
		this.FCFSAction.ShortLabel = global::Mono.Unix.Catalog.GetString("FCFS");
		w1.Add(this.FCFSAction, null);
		this.PNGAction1 = new global::Gtk.Action("PNGAction1", global::Mono.Unix.Catalog.GetString(".PNG"), null, null);
		this.PNGAction1.ShortLabel = global::Mono.Unix.Catalog.GetString(".PNG");
		w1.Add(this.PNGAction1, null);
		this.SVGAction1 = new global::Gtk.Action("SVGAction1", global::Mono.Unix.Catalog.GetString(".SVG"), null, null);
		this.SVGAction1.ShortLabel = global::Mono.Unix.Catalog.GetString(".SVG");
		w1.Add(this.SVGAction1, null);
		this.FCFSAction1 = new global::Gtk.Action("FCFSAction1", global::Mono.Unix.Catalog.GetString("FCFS"), null, null);
		this.FCFSAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("FCFS");
		w1.Add(this.FCFSAction1, null);
		this.SJFAction = new global::Gtk.Action("SJFAction", global::Mono.Unix.Catalog.GetString("SJF"), null, null);
		this.SJFAction.ShortLabel = global::Mono.Unix.Catalog.GetString("SJF");
		w1.Add(this.SJFAction, null);
		this.RRAction = new global::Gtk.Action("RRAction", global::Mono.Unix.Catalog.GetString("RR"), null, null);
		this.RRAction.ShortLabel = global::Mono.Unix.Catalog.GetString("RR");
		w1.Add(this.RRAction, null);
		this.PNGAction2 = new global::Gtk.Action("PNGAction2", global::Mono.Unix.Catalog.GetString(".PNG"), null, null);
		this.PNGAction2.ShortLabel = global::Mono.Unix.Catalog.GetString(".PNG");
		w1.Add(this.PNGAction2, null);
		this.SVGAction2 = new global::Gtk.Action("SVGAction2", global::Mono.Unix.Catalog.GetString(".SVG"), null, null);
		this.SVGAction2.ShortLabel = global::Mono.Unix.Catalog.GetString(".SVG");
		w1.Add(this.SVGAction2, null);
		this.PNGAction3 = new global::Gtk.Action("PNGAction3", global::Mono.Unix.Catalog.GetString(".PNG"), null, null);
		this.PNGAction3.ShortLabel = global::Mono.Unix.Catalog.GetString(".PNG");
		w1.Add(this.PNGAction3, null);
		this.SVGAction3 = new global::Gtk.Action("SVGAction3", global::Mono.Unix.Catalog.GetString(".SVG"), null, null);
		this.SVGAction3.ShortLabel = global::Mono.Unix.Catalog.GetString(".SVG");
		w1.Add(this.SVGAction3, null);
		this.PNGAction4 = new global::Gtk.Action("PNGAction4", global::Mono.Unix.Catalog.GetString(".PNG"), null, null);
		this.PNGAction4.ShortLabel = global::Mono.Unix.Catalog.GetString(".PNG");
		w1.Add(this.PNGAction4, null);
		this.SVGAction4 = new global::Gtk.Action("SVGAction4", global::Mono.Unix.Catalog.GetString(".SVG"), null, null);
		this.SVGAction4.ShortLabel = global::Mono.Unix.Catalog.GetString(".SVG");
		w1.Add(this.SVGAction4, null);
		this.TodosAction = new global::Gtk.Action("TodosAction", global::Mono.Unix.Catalog.GetString("Todos"), null, null);
		this.TodosAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Todos");
		w1.Add(this.TodosAction, null);
		this.PNGAction5 = new global::Gtk.Action("PNGAction5", global::Mono.Unix.Catalog.GetString(".PNG"), null, null);
		this.PNGAction5.ShortLabel = global::Mono.Unix.Catalog.GetString(".PNG");
		w1.Add(this.PNGAction5, null);
		this.SVGAction5 = new global::Gtk.Action("SVGAction5", global::Mono.Unix.Catalog.GetString(".SVG"), null, null);
		this.SVGAction5.ShortLabel = global::Mono.Unix.Catalog.GetString(".SVG");
		w1.Add(this.SVGAction5, null);
		this.ComparaoAction = new global::Gtk.Action("ComparaoAction", global::Mono.Unix.Catalog.GetString("Comparação"), null, null);
		this.ComparaoAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Comparação");
		w1.Add(this.ComparaoAction, null);
		this.PNGAction6 = new global::Gtk.Action("PNGAction6", global::Mono.Unix.Catalog.GetString(".PNG"), null, null);
		this.PNGAction6.ShortLabel = global::Mono.Unix.Catalog.GetString(".PNG");
		w1.Add(this.PNGAction6, null);
		this.SVGAction6 = new global::Gtk.Action("SVGAction6", global::Mono.Unix.Catalog.GetString(".SVG"), null, null);
		this.SVGAction6.ShortLabel = global::Mono.Unix.Catalog.GetString(".SVG");
		w1.Add(this.SVGAction6, null);
		this.AjudaAction = new global::Gtk.Action("AjudaAction", global::Mono.Unix.Catalog.GetString("Ajuda"), null, null);
		this.AjudaAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Ajuda");
		w1.Add(this.AjudaAction, null);
		this.SobreAction = new global::Gtk.Action("SobreAction", global::Mono.Unix.Catalog.GetString("Sobre"), null, null);
		this.SobreAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Sobre");
		w1.Add(this.SobreAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Scherduler#");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource("SchedulerSharp.icon512.png");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.DefaultWidth = 800;
		this.DefaultHeight = 600;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar3\'><menu name=\'dndAction\' action=\'dndAction\'><menuitem " +
				"name=\'newAction\' action=\'newAction\'/><menuitem name=\'editAction\' action=\'editAct" +
				"ion\'/><menuitem name=\'saveAction\' action=\'saveAction\'/><menuitem name=\'saveAsAct" +
				"ion\' action=\'saveAsAction\'/><menuitem name=\'closeAction\' action=\'closeAction\'/><" +
				"/menu><menu name=\'mediaPlayAction\' action=\'mediaPlayAction\'><menu name=\'director" +
				"yAction\' action=\'directoryAction\'><menu name=\'FCFSAction1\' action=\'FCFSAction1\'>" +
				"<menuitem name=\'PNGAction2\' action=\'PNGAction2\'/><menuitem name=\'SVGAction2\' act" +
				"ion=\'SVGAction2\'/></menu><menu name=\'SJFAction\' action=\'SJFAction\'><menuitem nam" +
				"e=\'PNGAction3\' action=\'PNGAction3\'/><menuitem name=\'SVGAction3\' action=\'SVGActio" +
				"n3\'/></menu><menu name=\'RRAction\' action=\'RRAction\'><menuitem name=\'PNGAction4\' " +
				"action=\'PNGAction4\'/><menuitem name=\'SVGAction4\' action=\'SVGAction4\'/></menu><me" +
				"nu name=\'ComparaoAction\' action=\'ComparaoAction\'><menuitem name=\'PNGAction6\' act" +
				"ion=\'PNGAction6\'/><menuitem name=\'SVGAction6\' action=\'SVGAction6\'/></menu><menu " +
				"name=\'TodosAction\' action=\'TodosAction\'><menuitem name=\'PNGAction5\' action=\'PNGA" +
				"ction5\'/><menuitem name=\'SVGAction5\' action=\'SVGAction5\'/></menu><menuitem name=" +
				"\'LogLogAction\' action=\'LogLogAction\'/><menuitem name=\'LogTxtAction\' action=\'LogT" +
				"xtAction\'/></menu><menu name=\'orientationPortraitAction\' action=\'orientationPort" +
				"raitAction\'><menuitem name=\'LogLogAction1\' action=\'LogLogAction1\'/></menu></menu" +
				"><menu name=\'findAndReplaceAction\' action=\'findAndReplaceAction\'><menuitem name=" +
				"\'convertAction\' action=\'convertAction\'/></menu><menu name=\'AjudaAction\' action=\'" +
				"AjudaAction\'><menuitem name=\'SobreAction\' action=\'SobreAction\'/></menu></menubar" +
				"></ui>");
		this.menubar3 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar3")));
		this.menubar3.Name = "menubar3";
		this.vbox1.Add(this.menubar3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar3]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.notebook1 = new global::Gtk.Notebook();
		this.notebook1.CanFocus = true;
		this.notebook1.Name = "notebook1";
		this.notebook1.CurrentPage = 0;
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
		this.SchedulerCombobox.AppendText(global::Mono.Unix.Catalog.GetString("FCFS"));
		this.SchedulerCombobox.AppendText(global::Mono.Unix.Catalog.GetString("SJF"));
		this.SchedulerCombobox.AppendText(global::Mono.Unix.Catalog.GetString("RR"));
		this.SchedulerCombobox.AppendText(global::Mono.Unix.Catalog.GetString("Compare"));
		this.SchedulerCombobox.WidthRequest = 160;
		this.SchedulerCombobox.Name = "SchedulerCombobox";
		this.SchedulerCombobox.Active = 0;
		this.menuBox.Add(this.SchedulerCombobox);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.menuBox[this.SchedulerCombobox]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child menuBox.Gtk.Box+BoxChild
		this.directoryEntry = global::Gtk.ComboBox.NewText();
		this.directoryEntry.Name = "directoryEntry";
		this.menuBox.Add(this.directoryEntry);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.menuBox[this.directoryEntry]));
		w4.Position = 1;
		this.simulatorBox.Add(this.menuBox);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.simulatorBox[this.menuBox]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child simulatorBox.Gtk.Box+BoxChild
		this.quantumBox = new global::Gtk.HBox();
		this.quantumBox.Name = "quantumBox";
		this.quantumBox.Spacing = 6;
		// Container child quantumBox.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Quantum");
		this.label1.Justify = ((global::Gtk.Justification)(2));
		this.quantumBox.Add(this.label1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.quantumBox[this.label1]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child quantumBox.Gtk.Box+BoxChild
		this.quantumScale = new global::Gtk.HScale(null);
		this.quantumScale.CanFocus = true;
		this.quantumScale.Name = "quantumScale";
		this.quantumScale.Adjustment.Lower = 1D;
		this.quantumScale.Adjustment.Upper = 100D;
		this.quantumScale.Adjustment.PageIncrement = 10D;
		this.quantumScale.Adjustment.StepIncrement = 1D;
		this.quantumScale.Adjustment.Value = 1D;
		this.quantumScale.DrawValue = true;
		this.quantumScale.Digits = 0;
		this.quantumScale.ValuePos = ((global::Gtk.PositionType)(1));
		this.quantumBox.Add(this.quantumScale);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.quantumBox[this.quantumScale]));
		w7.Position = 1;
		this.simulatorBox.Add(this.quantumBox);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.simulatorBox[this.quantumBox]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child simulatorBox.Gtk.Box+BoxChild
		this.plotBox = new global::Gtk.HPaned();
		this.plotBox.CanFocus = true;
		this.plotBox.Name = "plotBox";
		this.plotBox.Position = 328;
		this.simulatorBox.Add(this.plotBox);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.simulatorBox[this.plotBox]));
		w9.Position = 2;
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
		global::Gtk.Image w10 = new global::Gtk.Image();
		w10.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-media-previous", global::Gtk.IconSize.Button);
		this.previewButton.Image = w10;
		this.mediaBox.Add(this.previewButton);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.mediaBox[this.previewButton]));
		w11.Position = 0;
		// Container child mediaBox.Gtk.Box+BoxChild
		this.pauseButton = new global::Gtk.Button();
		this.pauseButton.CanFocus = true;
		this.pauseButton.Name = "pauseButton";
		this.pauseButton.UseUnderline = true;
		this.pauseButton.Label = global::Mono.Unix.Catalog.GetString("Pausa");
		global::Gtk.Image w12 = new global::Gtk.Image();
		w12.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-media-pause", global::Gtk.IconSize.Button);
		this.pauseButton.Image = w12;
		this.mediaBox.Add(this.pauseButton);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.mediaBox[this.pauseButton]));
		w13.Position = 1;
		// Container child mediaBox.Gtk.Box+BoxChild
		this.playButton = new global::Gtk.Button();
		this.playButton.CanFocus = true;
		this.playButton.Name = "playButton";
		this.playButton.UseUnderline = true;
		this.playButton.Label = global::Mono.Unix.Catalog.GetString("Iniciar");
		global::Gtk.Image w14 = new global::Gtk.Image();
		w14.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-media-play", global::Gtk.IconSize.Button);
		this.playButton.Image = w14;
		this.mediaBox.Add(this.playButton);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.mediaBox[this.playButton]));
		w15.Position = 2;
		// Container child mediaBox.Gtk.Box+BoxChild
		this.nextButton = new global::Gtk.Button();
		this.nextButton.CanFocus = true;
		this.nextButton.Name = "nextButton";
		this.nextButton.UseUnderline = true;
		this.nextButton.Label = global::Mono.Unix.Catalog.GetString("Avançar");
		global::Gtk.Image w16 = new global::Gtk.Image();
		w16.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-media-next", global::Gtk.IconSize.Button);
		this.nextButton.Image = w16;
		this.mediaBox.Add(this.nextButton);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.mediaBox[this.nextButton]));
		w17.Position = 3;
		this.simulatorBox.Add(this.mediaBox);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.simulatorBox[this.mediaBox]));
		w18.Position = 3;
		w18.Expand = false;
		w18.Fill = false;
		// Container child simulatorBox.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.progressFCFS = new global::Gtk.ProgressBar();
		this.progressFCFS.Name = "progressFCFS";
		this.progressFCFS.Text = global::Mono.Unix.Catalog.GetString("FCFS");
		this.hbox1.Add(this.progressFCFS);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.progressFCFS]));
		w19.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.progressSJF = new global::Gtk.ProgressBar();
		this.progressSJF.Name = "progressSJF";
		this.progressSJF.Text = global::Mono.Unix.Catalog.GetString("SJF");
		this.hbox1.Add(this.progressSJF);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.progressSJF]));
		w20.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.progressRR = new global::Gtk.ProgressBar();
		this.progressRR.Name = "progressRR";
		this.progressRR.Text = global::Mono.Unix.Catalog.GetString("RR");
		this.hbox1.Add(this.progressRR);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.progressRR]));
		w21.Position = 2;
		this.simulatorBox.Add(this.hbox1);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.simulatorBox[this.hbox1]));
		w22.PackType = ((global::Gtk.PackType)(1));
		w22.Position = 4;
		w22.Expand = false;
		w22.Fill = false;
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
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.cMenuBox[this.dirCreatorEntry]));
		w24.Position = 0;
		this.creatorBox.Add(this.cMenuBox);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.creatorBox[this.cMenuBox]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child creatorBox.Gtk.Box+BoxChild
		this.scrolledWindow = new global::Gtk.ScrolledWindow();
		this.scrolledWindow.CanFocus = true;
		this.scrolledWindow.Name = "scrolledWindow";
		this.scrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		this.creatorBox.Add(this.scrolledWindow);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.creatorBox[this.scrolledWindow]));
		w26.Position = 1;
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
		global::Gtk.Image w27 = new global::Gtk.Image();
		w27.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Button);
		this.addCreatorButton.Image = w27;
		this.settingsBox.Add(this.addCreatorButton);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.settingsBox[this.addCreatorButton]));
		w28.Position = 0;
		// Container child settingsBox.Gtk.Box+BoxChild
		this.removeCreatorButton = new global::Gtk.Button();
		this.removeCreatorButton.CanFocus = true;
		this.removeCreatorButton.Name = "removeCreatorButton";
		this.removeCreatorButton.UseUnderline = true;
		this.removeCreatorButton.Label = global::Mono.Unix.Catalog.GetString("Remover");
		global::Gtk.Image w29 = new global::Gtk.Image();
		w29.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "stock_delete", global::Gtk.IconSize.Button);
		this.removeCreatorButton.Image = w29;
		this.settingsBox.Add(this.removeCreatorButton);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.settingsBox[this.removeCreatorButton]));
		w30.Position = 1;
		this.creatorBox.Add(this.settingsBox);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.creatorBox[this.settingsBox]));
		w31.Position = 2;
		w31.Expand = false;
		w31.Fill = false;
		this.notebook1.Add(this.creatorBox);
		global::Gtk.Notebook.NotebookChild w32 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.creatorBox]));
		w32.Position = 1;
		// Notebook tab
		this.creationPageText = new global::Gtk.Label();
		this.creationPageText.Name = "creationPageText";
		this.creationPageText.LabelProp = global::Mono.Unix.Catalog.GetString("Criação");
		this.notebook1.SetTabLabel(this.creatorBox, this.creationPageText);
		this.creationPageText.ShowAll();
		this.vbox1.Add(this.notebook1);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.notebook1]));
		w33.Position = 1;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.newAction.Activated += new global::System.EventHandler(this.NewEvent);
		this.editAction.Activated += new global::System.EventHandler(this.EditButtonEvent);
		this.saveAction.Activated += new global::System.EventHandler(this.SaveEvent);
		this.saveAsAction.Activated += new global::System.EventHandler(this.SaveAsEvent);
		this.LogLogAction.Activated += new global::System.EventHandler(this.LogJsonEvent);
		this.closeAction.Activated += new global::System.EventHandler(this.CloseEvent);
		this.LogTxtAction.Activated += new global::System.EventHandler(this.LogTxtEvent);
		this.LogLogAction1.Activated += new global::System.EventHandler(this.OnOpenLogJson);
		this.PNGAction2.Activated += new global::System.EventHandler(this.ExportFCFSPNG);
		this.SVGAction2.Activated += new global::System.EventHandler(this.ExportFCFSSVG);
		this.PNGAction3.Activated += new global::System.EventHandler(this.ExportSJFPNG);
		this.SVGAction3.Activated += new global::System.EventHandler(this.ExportSJFSVG);
		this.PNGAction4.Activated += new global::System.EventHandler(this.ExportRRPNG);
		this.SVGAction4.Activated += new global::System.EventHandler(this.ExportRRSVG);
		this.PNGAction5.Activated += new global::System.EventHandler(this.ExportALLPNG);
		this.SVGAction5.Activated += new global::System.EventHandler(this.ExportALLSVG);
		this.PNGAction6.Activated += new global::System.EventHandler(this.ExportComparePNG);
		this.SVGAction6.Activated += new global::System.EventHandler(this.ExportCompareSVG);
		this.SobreAction.Activated += new global::System.EventHandler(this.AboutWindowOpen);
		this.SchedulerCombobox.Changed += new global::System.EventHandler(this.OnSelectScheduler);
		this.directoryEntry.Changed += new global::System.EventHandler(this.OnChangeDirEntry);
		this.quantumScale.ValueChanged += new global::System.EventHandler(this.OnQuantumChange);
		this.previewButton.Clicked += new global::System.EventHandler(this.PreviewEvent);
		this.pauseButton.Clicked += new global::System.EventHandler(this.PauseEvent);
		this.playButton.Clicked += new global::System.EventHandler(this.PlayEvent);
		this.nextButton.Clicked += new global::System.EventHandler(this.NextEvent);
		this.dirCreatorEntry.Changed += new global::System.EventHandler(this.OnChangeDirEntry);
		this.addCreatorButton.Clicked += new global::System.EventHandler(this.AddCreationEvent);
		this.removeCreatorButton.Clicked += new global::System.EventHandler(this.RemoveCreationEvent);
	}
}
