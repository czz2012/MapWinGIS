﻿namespace TestApplication
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.groupBox11 = new System.Windows.Forms.GroupBox();
      this.groupBox10 = new System.Windows.Forms.GroupBox();
      this.groupBox12 = new System.Windows.Forms.GroupBox();
      this.RunBufferShapefileTest = new System.Windows.Forms.Button();
      this.SelectBufferShapefile = new System.Windows.Forms.Button();
      this.BufferShapefileInput = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.groupBox9 = new System.Windows.Forms.GroupBox();
      this.RunRasterizeTest = new System.Windows.Forms.Button();
      this.SelectRasterizeInputfile = new System.Windows.Forms.Button();
      this.RasterizeInputfile = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.RunShapefileToGridTest = new System.Windows.Forms.Button();
      this.SelectShapefileToGrid = new System.Windows.Forms.Button();
      this.ShapefileToGrid = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.RunClipGridByPolygonTest = new System.Windows.Forms.Button();
      this.SelectClippingPolygon = new System.Windows.Forms.Button();
      this.ClippingPolygon = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.SelectGridfileToClip = new System.Windows.Forms.Button();
      this.GridfileToClip = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.RunImageTest = new System.Windows.Forms.Button();
      this.SelectImageInputfile = new System.Windows.Forms.Button();
      this.ImageInputfile = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.RunGridTest = new System.Windows.Forms.Button();
      this.SelectGridInputfile = new System.Windows.Forms.Button();
      this.GridInputfile = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.RunShapefileTest = new System.Windows.Forms.Button();
      this.SelectShapefileInputfile = new System.Windows.Forms.Button();
      this.ShapefileInputfile = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.axMap1 = new AxMapWinGIS.AxMap();
      this.Progressbox = new System.Windows.Forms.TextBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.groupBox10.SuspendLayout();
      this.groupBox12.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.Progressbox);
      this.splitContainer1.Size = new System.Drawing.Size(667, 564);
      this.splitContainer1.SplitterDistance = 461;
      this.splitContainer1.TabIndex = 0;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer2.Location = new System.Drawing.Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.AutoScroll = true;
      this.splitContainer2.Panel1.Controls.Add(this.groupBox11);
      this.splitContainer2.Panel1.Controls.Add(this.groupBox10);
      this.splitContainer2.Panel1.Controls.Add(this.groupBox8);
      this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
      this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
      this.splitContainer2.Panel1.Controls.Add(this.label1);
      this.splitContainer2.Panel1MinSize = 30;
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.axMap1);
      this.splitContainer2.Size = new System.Drawing.Size(667, 461);
      this.splitContainer2.SplitterDistance = 230;
      this.splitContainer2.TabIndex = 0;
      // 
      // groupBox11
      // 
      this.groupBox11.Location = new System.Drawing.Point(3, 886);
      this.groupBox11.Name = "groupBox11";
      this.groupBox11.Size = new System.Drawing.Size(205, 58);
      this.groupBox11.TabIndex = 5;
      this.groupBox11.TabStop = false;
      this.groupBox11.Text = "groupBox11";
      // 
      // groupBox10
      // 
      this.groupBox10.Controls.Add(this.groupBox12);
      this.groupBox10.Location = new System.Drawing.Point(3, 722);
      this.groupBox10.Name = "groupBox10";
      this.groupBox10.Size = new System.Drawing.Size(205, 116);
      this.groupBox10.TabIndex = 4;
      this.groupBox10.TabStop = false;
      this.groupBox10.Text = "GEOS Methods";
      // 
      // groupBox12
      // 
      this.groupBox12.Controls.Add(this.RunBufferShapefileTest);
      this.groupBox12.Controls.Add(this.SelectBufferShapefile);
      this.groupBox12.Controls.Add(this.BufferShapefileInput);
      this.groupBox12.Controls.Add(this.label9);
      this.groupBox12.Location = new System.Drawing.Point(6, 19);
      this.groupBox12.Name = "groupBox12";
      this.groupBox12.Size = new System.Drawing.Size(195, 89);
      this.groupBox12.TabIndex = 3;
      this.groupBox12.TabStop = false;
      this.groupBox12.Text = "Buffer shapefile";
      // 
      // RunBufferShapefileTest
      // 
      this.RunBufferShapefileTest.Location = new System.Drawing.Point(9, 58);
      this.RunBufferShapefileTest.Name = "RunBufferShapefileTest";
      this.RunBufferShapefileTest.Size = new System.Drawing.Size(180, 23);
      this.RunBufferShapefileTest.TabIndex = 9;
      this.RunBufferShapefileTest.Text = "Run test";
      this.RunBufferShapefileTest.UseVisualStyleBackColor = true;
      this.RunBufferShapefileTest.Click += new System.EventHandler(this.RunBufferShapefileTestClick);
      // 
      // SelectBufferShapefile
      // 
      this.SelectBufferShapefile.Location = new System.Drawing.Point(162, 32);
      this.SelectBufferShapefile.Name = "SelectBufferShapefile";
      this.SelectBufferShapefile.Size = new System.Drawing.Size(27, 20);
      this.SelectBufferShapefile.TabIndex = 8;
      this.SelectBufferShapefile.Text = "...";
      this.toolTip1.SetToolTip(this.SelectBufferShapefile, "Select text file with on every line the location of a shapefile");
      this.SelectBufferShapefile.UseVisualStyleBackColor = true;
      this.SelectBufferShapefile.Click += new System.EventHandler(this.SelectBufferShapefileClick);
      // 
      // BufferShapefileInput
      // 
      this.BufferShapefileInput.AcceptsReturn = true;
      this.BufferShapefileInput.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestApplication.Properties.Settings.Default, "BufferShapefile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.BufferShapefileInput.Location = new System.Drawing.Point(9, 32);
      this.BufferShapefileInput.Name = "BufferShapefileInput";
      this.BufferShapefileInput.Size = new System.Drawing.Size(147, 20);
      this.BufferShapefileInput.TabIndex = 7;
      this.BufferShapefileInput.Text = global::TestApplication.Properties.Settings.Default.BufferShapefile;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 16);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(103, 13);
      this.label9.TabIndex = 6;
      this.label9.Text = "Select the shapefile:";
      // 
      // groupBox8
      // 
      this.groupBox8.Controls.Add(this.groupBox9);
      this.groupBox8.Location = new System.Drawing.Point(3, 598);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new System.Drawing.Size(205, 118);
      this.groupBox8.TabIndex = 3;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "GDAL Methods";
      // 
      // groupBox9
      // 
      this.groupBox9.Controls.Add(this.RunRasterizeTest);
      this.groupBox9.Controls.Add(this.SelectRasterizeInputfile);
      this.groupBox9.Controls.Add(this.RasterizeInputfile);
      this.groupBox9.Controls.Add(this.label8);
      this.groupBox9.Location = new System.Drawing.Point(6, 19);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new System.Drawing.Size(195, 89);
      this.groupBox9.TabIndex = 2;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Rasterize shapefile";
      // 
      // RunRasterizeTest
      // 
      this.RunRasterizeTest.Location = new System.Drawing.Point(9, 58);
      this.RunRasterizeTest.Name = "RunRasterizeTest";
      this.RunRasterizeTest.Size = new System.Drawing.Size(180, 23);
      this.RunRasterizeTest.TabIndex = 9;
      this.RunRasterizeTest.Text = "Run test";
      this.RunRasterizeTest.UseVisualStyleBackColor = true;
      this.RunRasterizeTest.Click += new System.EventHandler(this.RunRasterizeTestClick);
      // 
      // SelectRasterizeInputfile
      // 
      this.SelectRasterizeInputfile.Location = new System.Drawing.Point(162, 32);
      this.SelectRasterizeInputfile.Name = "SelectRasterizeInputfile";
      this.SelectRasterizeInputfile.Size = new System.Drawing.Size(27, 20);
      this.SelectRasterizeInputfile.TabIndex = 8;
      this.SelectRasterizeInputfile.Text = "...";
      this.toolTip1.SetToolTip(this.SelectRasterizeInputfile, "Select text file with on every line the location of a shapefile");
      this.SelectRasterizeInputfile.UseVisualStyleBackColor = true;
      this.SelectRasterizeInputfile.Click += new System.EventHandler(this.SelectRasterizeInputfileClick);
      // 
      // RasterizeInputfile
      // 
      this.RasterizeInputfile.AcceptsReturn = true;
      this.RasterizeInputfile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestApplication.Properties.Settings.Default, "RasterizeInputfile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.RasterizeInputfile.Location = new System.Drawing.Point(9, 32);
      this.RasterizeInputfile.Name = "RasterizeInputfile";
      this.RasterizeInputfile.Size = new System.Drawing.Size(147, 20);
      this.RasterizeInputfile.TabIndex = 7;
      this.RasterizeInputfile.Text = global::TestApplication.Properties.Settings.Default.RasterizeInputfile;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(6, 16);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(114, 13);
      this.label8.TabIndex = 6;
      this.label8.Text = "Select the polygon file:";
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.groupBox7);
      this.groupBox5.Controls.Add(this.groupBox6);
      this.groupBox5.Location = new System.Drawing.Point(3, 340);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(205, 252);
      this.groupBox5.TabIndex = 2;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Spatial operations";
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.RunShapefileToGridTest);
      this.groupBox7.Controls.Add(this.SelectShapefileToGrid);
      this.groupBox7.Controls.Add(this.ShapefileToGrid);
      this.groupBox7.Controls.Add(this.label7);
      this.groupBox7.Location = new System.Drawing.Point(6, 154);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(195, 89);
      this.groupBox7.TabIndex = 1;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Shapefile to grid";
      // 
      // RunShapefileToGridTest
      // 
      this.RunShapefileToGridTest.Location = new System.Drawing.Point(9, 58);
      this.RunShapefileToGridTest.Name = "RunShapefileToGridTest";
      this.RunShapefileToGridTest.Size = new System.Drawing.Size(180, 23);
      this.RunShapefileToGridTest.TabIndex = 9;
      this.RunShapefileToGridTest.Text = "Run test";
      this.RunShapefileToGridTest.UseVisualStyleBackColor = true;
      this.RunShapefileToGridTest.Click += new System.EventHandler(this.RunShapefileToGridTestClick);
      // 
      // SelectShapefileToGrid
      // 
      this.SelectShapefileToGrid.Location = new System.Drawing.Point(162, 32);
      this.SelectShapefileToGrid.Name = "SelectShapefileToGrid";
      this.SelectShapefileToGrid.Size = new System.Drawing.Size(27, 20);
      this.SelectShapefileToGrid.TabIndex = 8;
      this.SelectShapefileToGrid.Text = "...";
      this.toolTip1.SetToolTip(this.SelectShapefileToGrid, "Select text file with on every line the location of a shapefile");
      this.SelectShapefileToGrid.UseVisualStyleBackColor = true;
      this.SelectShapefileToGrid.Click += new System.EventHandler(this.SelectShapefileToGridClick);
      // 
      // ShapefileToGrid
      // 
      this.ShapefileToGrid.AcceptsReturn = true;
      this.ShapefileToGrid.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestApplication.Properties.Settings.Default, "ShapefileToGrid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ShapefileToGrid.Location = new System.Drawing.Point(9, 32);
      this.ShapefileToGrid.Name = "ShapefileToGrid";
      this.ShapefileToGrid.Size = new System.Drawing.Size(147, 20);
      this.ShapefileToGrid.TabIndex = 7;
      this.ShapefileToGrid.Text = global::TestApplication.Properties.Settings.Default.ShapefileToGrid;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 16);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(114, 13);
      this.label7.TabIndex = 6;
      this.label7.Text = "Select the polygon file:";
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.RunClipGridByPolygonTest);
      this.groupBox6.Controls.Add(this.SelectClippingPolygon);
      this.groupBox6.Controls.Add(this.ClippingPolygon);
      this.groupBox6.Controls.Add(this.label6);
      this.groupBox6.Controls.Add(this.SelectGridfileToClip);
      this.groupBox6.Controls.Add(this.GridfileToClip);
      this.groupBox6.Controls.Add(this.label5);
      this.groupBox6.Location = new System.Drawing.Point(6, 19);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(195, 129);
      this.groupBox6.TabIndex = 0;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Clip grid by polygon";
      // 
      // RunClipGridByPolygonTest
      // 
      this.RunClipGridByPolygonTest.Location = new System.Drawing.Point(9, 97);
      this.RunClipGridByPolygonTest.Name = "RunClipGridByPolygonTest";
      this.RunClipGridByPolygonTest.Size = new System.Drawing.Size(180, 23);
      this.RunClipGridByPolygonTest.TabIndex = 9;
      this.RunClipGridByPolygonTest.Text = "Run test";
      this.RunClipGridByPolygonTest.UseVisualStyleBackColor = true;
      this.RunClipGridByPolygonTest.Click += new System.EventHandler(this.RunClipGridByPolygonTestClick);
      // 
      // SelectClippingPolygon
      // 
      this.SelectClippingPolygon.Location = new System.Drawing.Point(162, 71);
      this.SelectClippingPolygon.Name = "SelectClippingPolygon";
      this.SelectClippingPolygon.Size = new System.Drawing.Size(27, 20);
      this.SelectClippingPolygon.TabIndex = 8;
      this.SelectClippingPolygon.Text = "...";
      this.toolTip1.SetToolTip(this.SelectClippingPolygon, "Select text file with on every line the location of a shapefile");
      this.SelectClippingPolygon.UseVisualStyleBackColor = true;
      this.SelectClippingPolygon.Click += new System.EventHandler(this.SelectClippingPolygonClick);
      // 
      // ClippingPolygon
      // 
      this.ClippingPolygon.AcceptsReturn = true;
      this.ClippingPolygon.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestApplication.Properties.Settings.Default, "ClippingPolygon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ClippingPolygon.Location = new System.Drawing.Point(9, 71);
      this.ClippingPolygon.Name = "ClippingPolygon";
      this.ClippingPolygon.Size = new System.Drawing.Size(147, 20);
      this.ClippingPolygon.TabIndex = 7;
      this.ClippingPolygon.Text = global::TestApplication.Properties.Settings.Default.ClippingPolygon;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 55);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(114, 13);
      this.label6.TabIndex = 6;
      this.label6.Text = "Select the polygon file:";
      // 
      // SelectGridfileToClip
      // 
      this.SelectGridfileToClip.Location = new System.Drawing.Point(162, 32);
      this.SelectGridfileToClip.Name = "SelectGridfileToClip";
      this.SelectGridfileToClip.Size = new System.Drawing.Size(27, 20);
      this.SelectGridfileToClip.TabIndex = 5;
      this.SelectGridfileToClip.Text = "...";
      this.toolTip1.SetToolTip(this.SelectGridfileToClip, "Select text file with on every line the location of a shapefile");
      this.SelectGridfileToClip.UseVisualStyleBackColor = true;
      this.SelectGridfileToClip.Click += new System.EventHandler(this.SelectGridfileToClipClick);
      // 
      // GridfileToClip
      // 
      this.GridfileToClip.AcceptsReturn = true;
      this.GridfileToClip.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestApplication.Properties.Settings.Default, "GridfileToClip", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.GridfileToClip.Location = new System.Drawing.Point(9, 32);
      this.GridfileToClip.Name = "GridfileToClip";
      this.GridfileToClip.Size = new System.Drawing.Size(147, 20);
      this.GridfileToClip.TabIndex = 4;
      this.GridfileToClip.Text = global::TestApplication.Properties.Settings.Default.GridfileToClip;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 16);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(94, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Select the grid file:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.groupBox4);
      this.groupBox1.Controls.Add(this.groupBox3);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Location = new System.Drawing.Point(3, 28);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(205, 306);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "File formats";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.RunImageTest);
      this.groupBox4.Controls.Add(this.SelectImageInputfile);
      this.groupBox4.Controls.Add(this.ImageInputfile);
      this.groupBox4.Controls.Add(this.label4);
      this.groupBox4.Location = new System.Drawing.Point(6, 209);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(195, 89);
      this.groupBox4.TabIndex = 2;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Image files";
      // 
      // RunImageTest
      // 
      this.RunImageTest.Location = new System.Drawing.Point(9, 58);
      this.RunImageTest.Name = "RunImageTest";
      this.RunImageTest.Size = new System.Drawing.Size(180, 23);
      this.RunImageTest.TabIndex = 3;
      this.RunImageTest.Text = "Run test";
      this.RunImageTest.UseVisualStyleBackColor = true;
      this.RunImageTest.Click += new System.EventHandler(this.RunImageTestClick);
      // 
      // SelectImageInputfile
      // 
      this.SelectImageInputfile.Location = new System.Drawing.Point(162, 32);
      this.SelectImageInputfile.Name = "SelectImageInputfile";
      this.SelectImageInputfile.Size = new System.Drawing.Size(27, 20);
      this.SelectImageInputfile.TabIndex = 2;
      this.SelectImageInputfile.Text = "...";
      this.SelectImageInputfile.UseVisualStyleBackColor = true;
      this.SelectImageInputfile.Click += new System.EventHandler(this.SelectImageInputfileClick);
      // 
      // ImageInputfile
      // 
      this.ImageInputfile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestApplication.Properties.Settings.Default, "ImageInputText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ImageInputfile.Location = new System.Drawing.Point(9, 32);
      this.ImageInputfile.Name = "ImageInputfile";
      this.ImageInputfile.Size = new System.Drawing.Size(147, 20);
      this.ImageInputfile.TabIndex = 1;
      this.ImageInputfile.Text = global::TestApplication.Properties.Settings.Default.ImageInputText;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 16);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(179, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Select a txt file with the files to open:";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.RunGridTest);
      this.groupBox3.Controls.Add(this.SelectGridInputfile);
      this.groupBox3.Controls.Add(this.GridInputfile);
      this.groupBox3.Controls.Add(this.label3);
      this.groupBox3.Location = new System.Drawing.Point(6, 114);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(195, 89);
      this.groupBox3.TabIndex = 1;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Grid files";
      // 
      // RunGridTest
      // 
      this.RunGridTest.Location = new System.Drawing.Point(9, 58);
      this.RunGridTest.Name = "RunGridTest";
      this.RunGridTest.Size = new System.Drawing.Size(180, 23);
      this.RunGridTest.TabIndex = 3;
      this.RunGridTest.Text = "Run test";
      this.RunGridTest.UseVisualStyleBackColor = true;
      this.RunGridTest.Click += new System.EventHandler(this.RunGridTestClick);
      // 
      // SelectGridInputfile
      // 
      this.SelectGridInputfile.Location = new System.Drawing.Point(162, 32);
      this.SelectGridInputfile.Name = "SelectGridInputfile";
      this.SelectGridInputfile.Size = new System.Drawing.Size(27, 20);
      this.SelectGridInputfile.TabIndex = 2;
      this.SelectGridInputfile.Text = "...";
      this.SelectGridInputfile.UseVisualStyleBackColor = true;
      this.SelectGridInputfile.Click += new System.EventHandler(this.SelectGridInputfileClick);
      // 
      // GridInputfile
      // 
      this.GridInputfile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestApplication.Properties.Settings.Default, "GridInputText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.GridInputfile.Location = new System.Drawing.Point(9, 32);
      this.GridInputfile.Name = "GridInputfile";
      this.GridInputfile.Size = new System.Drawing.Size(147, 20);
      this.GridInputfile.TabIndex = 1;
      this.GridInputfile.Text = global::TestApplication.Properties.Settings.Default.GridInputText;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 16);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(179, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Select a txt file with the files to open:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.RunShapefileTest);
      this.groupBox2.Controls.Add(this.SelectShapefileInputfile);
      this.groupBox2.Controls.Add(this.ShapefileInputfile);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Location = new System.Drawing.Point(6, 19);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(195, 89);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Shapefiles";
      // 
      // RunShapefileTest
      // 
      this.RunShapefileTest.Location = new System.Drawing.Point(9, 58);
      this.RunShapefileTest.Name = "RunShapefileTest";
      this.RunShapefileTest.Size = new System.Drawing.Size(180, 23);
      this.RunShapefileTest.TabIndex = 3;
      this.RunShapefileTest.Text = "Run test";
      this.RunShapefileTest.UseVisualStyleBackColor = true;
      this.RunShapefileTest.Click += new System.EventHandler(this.RunShapefileTestClick);
      // 
      // SelectShapefileInputfile
      // 
      this.SelectShapefileInputfile.Location = new System.Drawing.Point(162, 32);
      this.SelectShapefileInputfile.Name = "SelectShapefileInputfile";
      this.SelectShapefileInputfile.Size = new System.Drawing.Size(27, 20);
      this.SelectShapefileInputfile.TabIndex = 2;
      this.SelectShapefileInputfile.Text = "...";
      this.toolTip1.SetToolTip(this.SelectShapefileInputfile, "Select text file with on every line the location of a shapefile");
      this.SelectShapefileInputfile.UseVisualStyleBackColor = true;
      this.SelectShapefileInputfile.Click += new System.EventHandler(this.SelectShapefileInputfileClick);
      // 
      // ShapefileInputfile
      // 
      this.ShapefileInputfile.AcceptsReturn = true;
      this.ShapefileInputfile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TestApplication.Properties.Settings.Default, "ShapefileInputText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ShapefileInputfile.Location = new System.Drawing.Point(9, 32);
      this.ShapefileInputfile.Name = "ShapefileInputfile";
      this.ShapefileInputfile.Size = new System.Drawing.Size(147, 20);
      this.ShapefileInputfile.TabIndex = 1;
      this.ShapefileInputfile.Text = global::TestApplication.Properties.Settings.Default.ShapefileInputText;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(179, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Select a txt file with the files to open:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tests";
      // 
      // axMap1
      // 
      this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.axMap1.Enabled = true;
      this.axMap1.Location = new System.Drawing.Point(0, 0);
      this.axMap1.Name = "axMap1";
      this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
      this.axMap1.Size = new System.Drawing.Size(433, 461);
      this.axMap1.TabIndex = 0;
      this.axMap1.FileDropped += new AxMapWinGIS._DMapEvents_FileDroppedEventHandler(this.AxMap1FileDropped);
      // 
      // Progressbox
      // 
      this.Progressbox.BackColor = System.Drawing.Color.White;
      this.Progressbox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Progressbox.Location = new System.Drawing.Point(0, 0);
      this.Progressbox.Multiline = true;
      this.Progressbox.Name = "Progressbox";
      this.Progressbox.ReadOnly = true;
      this.Progressbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Progressbox.Size = new System.Drawing.Size(667, 99);
      this.Progressbox.TabIndex = 0;
      this.Progressbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProgressboxMouseClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(667, 564);
      this.Controls.Add(this.splitContainer1);
      this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TestApplication.Properties.Settings.Default, "FormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.Location = global::TestApplication.Properties.Settings.Default.FormLocation;
      this.MinimumSize = new System.Drawing.Size(680, 520);
      this.Name = "Form1";
      this.Text = "Test application for MapWinGIS";
      this.Load += new System.EventHandler(this.Form1Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel1.PerformLayout();
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.ResumeLayout(false);
      this.groupBox10.ResumeLayout(false);
      this.groupBox12.ResumeLayout(false);
      this.groupBox12.PerformLayout();
      this.groupBox8.ResumeLayout(false);
      this.groupBox9.ResumeLayout(false);
      this.groupBox9.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button RunShapefileTest;
    private System.Windows.Forms.Button SelectShapefileInputfile;
    private System.Windows.Forms.TextBox ShapefileInputfile;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button RunImageTest;
    private System.Windows.Forms.Button SelectImageInputfile;
    private System.Windows.Forms.TextBox ImageInputfile;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button RunGridTest;
    private System.Windows.Forms.Button SelectGridInputfile;
    private System.Windows.Forms.TextBox GridInputfile;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ToolTip toolTip1;
    private AxMapWinGIS.AxMap axMap1;
    private System.Windows.Forms.TextBox Progressbox;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.Button SelectGridfileToClip;
    private System.Windows.Forms.TextBox GridfileToClip;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button SelectClippingPolygon;
    private System.Windows.Forms.TextBox ClippingPolygon;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button RunClipGridByPolygonTest;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.Button RunShapefileToGridTest;
    private System.Windows.Forms.Button SelectShapefileToGrid;
    private System.Windows.Forms.TextBox ShapefileToGrid;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.GroupBox groupBox8;
    private System.Windows.Forms.GroupBox groupBox9;
    private System.Windows.Forms.Button RunRasterizeTest;
    private System.Windows.Forms.Button SelectRasterizeInputfile;
    private System.Windows.Forms.TextBox RasterizeInputfile;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.GroupBox groupBox11;
    private System.Windows.Forms.GroupBox groupBox10;
    private System.Windows.Forms.GroupBox groupBox12;
    private System.Windows.Forms.Button RunBufferShapefileTest;
    private System.Windows.Forms.Button SelectBufferShapefile;
    private System.Windows.Forms.TextBox BufferShapefileInput;
    private System.Windows.Forms.Label label9;
  }
}

