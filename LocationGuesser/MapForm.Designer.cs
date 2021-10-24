
namespace FindMyLocations
{
	partial class MapForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
			
			this.map = new GMap.NET.WindowsForms.GMapControl();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.newLocation = new System.Windows.Forms.Button();
			this.distanceLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.timerLbl = new System.Windows.Forms.Label();
			this.chooseBtn = new System.Windows.Forms.Button();
			this.backBtn = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// map
			// 
			this.map.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.map.Bearing = 0F;
			this.map.CanDragMap = true;
			this.map.Dock = System.Windows.Forms.DockStyle.Fill;
			this.map.EmptyTileColor = System.Drawing.Color.Navy;
			this.map.GrayScaleMode = false;
			this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.map.LevelsKeepInMemory = 5;
			this.map.Location = new System.Drawing.Point(1375, 64);
			this.map.Margin = new System.Windows.Forms.Padding(4);
			this.map.MarkersEnabled = true;
			this.map.MaxZoom = 2;
			this.map.MinZoom = 2;
			this.map.MouseWheelZoomEnabled = true;
			this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.map.Name = "map";
			this.map.NegativeMode = false;
			this.map.Padding = new System.Windows.Forms.Padding(1);
			this.map.PolygonsEnabled = true;
			this.map.RetryLoadTile = 0;
			this.map.RoutesEnabled = true;
			this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.map.ShowTileGridLines = false;
			this.map.Size = new System.Drawing.Size(679, 597);
			this.map.TabIndex = 1;
			this.map.Zoom = 0D;
			// 
			// webBrowser
			// 
			this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser.Location = new System.Drawing.Point(3, 3);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.tableLayoutPanel.SetRowSpan(this.webBrowser, 7);
			this.webBrowser.ScrollBarsEnabled = false;
			this.webBrowser.Size = new System.Drawing.Size(1365, 1180);
			this.webBrowser.TabIndex = 2;
			// 
			// newLocation
			// 
			this.newLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.newLocation.BackColor = System.Drawing.Color.DodgerBlue;
			this.newLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newLocation.ForeColor = System.Drawing.Color.White;
			this.newLocation.Location = new System.Drawing.Point(1381, 912);
			this.newLocation.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.newLocation.Name = "newLocation";
			this.newLocation.Size = new System.Drawing.Size(667, 111);
			this.newLocation.TabIndex = 4;
			this.newLocation.Text = "New location";
			this.newLocation.UseVisualStyleBackColor = false;
			this.newLocation.Click += new System.EventHandler(this.newLocation_Click);
			// 
			// distanceLbl
			// 
			this.distanceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.distanceLbl.AutoSize = true;
			this.distanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distanceLbl.Location = new System.Drawing.Point(1653, 709);
			this.distanceLbl.Name = "distanceLbl";
			this.distanceLbl.Size = new System.Drawing.Size(122, 32);
			this.distanceLbl.TabIndex = 5;
			this.distanceLbl.Text = "distance";
			this.distanceLbl.Visible = false;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AutoSize = true;
			this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel.Controls.Add(this.webBrowser, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.timerLbl, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.map, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.distanceLbl, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.chooseBtn, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.newLocation, 1, 4);
			this.tableLayoutPanel.Controls.Add(this.backBtn, 1, 5);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 5;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.102041F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.061224F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(2058, 1186);
			this.tableLayoutPanel.TabIndex = 6;
			// 
			// timerLbl
			// 
			this.timerLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.timerLbl.AutoSize = true;
			this.timerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timerLbl.Location = new System.Drawing.Point(1651, 14);
			this.timerLbl.Name = "timerLbl";
			this.timerLbl.Size = new System.Drawing.Size(127, 32);
			this.timerLbl.TabIndex = 3;
			this.timerLbl.Text = "00:00:00";
			// 
			// chooseBtn
			// 
			this.chooseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chooseBtn.BackColor = System.Drawing.Color.DodgerBlue;
			this.chooseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chooseBtn.ForeColor = System.Drawing.Color.White;
			this.chooseBtn.Location = new System.Drawing.Point(1381, 791);
			this.chooseBtn.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.chooseBtn.Name = "chooseBtn";
			this.chooseBtn.Size = new System.Drawing.Size(667, 111);
			this.chooseBtn.TabIndex = 3;
			this.chooseBtn.Text = "Choose";
			this.chooseBtn.UseVisualStyleBackColor = false;
			this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
			// 
			// backBtn
			// 
			this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.backBtn.BackColor = System.Drawing.Color.DodgerBlue;
			this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backBtn.ForeColor = System.Drawing.Color.White;
			this.backBtn.Location = new System.Drawing.Point(1381, 1033);
			this.backBtn.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(667, 111);
			this.backBtn.TabIndex = 6;
			this.backBtn.Text = "About";
			this.backBtn.UseVisualStyleBackColor = false;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// MapForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(2058, 1186);
			this.Controls.Add(this.tableLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(900, 800);
			this.Name = "MapForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Location Guesser";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private GMap.NET.WindowsForms.GMapControl map;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Button newLocation;
		private System.Windows.Forms.Label distanceLbl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label timerLbl;
		private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.Button chooseBtn;
		private System.Windows.Forms.Timer timer;
	}
}

