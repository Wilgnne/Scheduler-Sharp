
// This file has been generated by the GUI designer. Do not modify.
namespace SchedulerSharp
{
	public partial class ImportView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.ComboBox combobox1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget SchedulerSharp.ImportView
			this.Name = "SchedulerSharp.ImportView";
			this.Title = global::Mono.Unix.Catalog.GetString("Visualização de LOG");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource("SchedulerSharp.icon512.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child SchedulerSharp.ImportView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.combobox1 = global::Gtk.ComboBox.NewText();
			this.combobox1.AppendText(global::Mono.Unix.Catalog.GetString("FCFS"));
			this.combobox1.AppendText(global::Mono.Unix.Catalog.GetString("SJF"));
			this.combobox1.AppendText(global::Mono.Unix.Catalog.GetString("RR"));
			this.combobox1.Name = "combobox1";
			this.combobox1.Active = 0;
			this.vbox1.Add(this.combobox1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.combobox1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.combobox1.Changed += new global::System.EventHandler(this.OnSelectScheduler);
		}
	}
}