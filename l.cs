using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

public class l : Form
{
	private m m_a;

	private int m_b;

	private int m_c;

	private int m_d;

	private int m_e;

	private int f;

	private int g;

	private int h;

	private int i;

	private int j;

	private int k;

	private int m_l;

	private Graphics m;

	private Pen n;

	private Pen o;

	private Pen p;

	private Font q;

	private SolidBrush r;

	private SolidBrush s;

	private SolidBrush t;

	private StringFormat u;

	private IContainer v;

	private Label w;

	private ListView x;

	private ColumnHeader y;

	private ColumnHeader z;

	private ColumnHeader aa;

	private Label ab;

	private Button ac;

	private Timer ad;

	private Timer ae;

	private Timer af;

	private ImageList ag;

	public l(m A_0)
	{
		this.m_a = A_0;
		a();
		d();
	}

	private void d()
	{
		x.Items.Clear();
		x.Items.Add("  Main");
		x.Items.Add("  Main");
		x.Items.Add("  Main");
		x.Items.Add("  Advanced");
		x.Items.Add("  Advanced");
		x.Items.Add("  Advanced");
		x.Items.Add("  Advanced");
		x.Items.Add("  Power");
		x.Items.Add("  Power");
		x.Items.Add("  Boot");
		for (int num = 0; num < 10; num++)
		{
			switch (num)
			{
			case 0:
				x.Items[num].SubItems.Add(this.m_a.s[0]);
				break;
			case 1:
				x.Items[num].SubItems.Add(this.m_a.t[0]);
				break;
			case 2:
				x.Items[num].SubItems.Add(this.m_a.u[0]);
				break;
			case 3:
				x.Items[num].SubItems.Add(this.m_a.v[0]);
				break;
			case 4:
				x.Items[num].SubItems.Add(this.m_a.w[0]);
				break;
			case 5:
				x.Items[num].SubItems.Add(this.m_a.x[0]);
				break;
			case 6:
				x.Items[num].SubItems.Add(this.m_a.y[0]);
				break;
			case 7:
				x.Items[num].SubItems.Add(this.m_a.z[0]);
				break;
			case 8:
				x.Items[num].SubItems.Add(this.m_a.aa[0]);
				break;
			case 9:
				x.Items[num].SubItems.Add(this.m_a.ab[0]);
				break;
			}
			if (this.m_a.r[num])
			{
				x.Items[num].ImageIndex = 0;
				x.Items[num].ForeColor = Color.Green;
				x.Items[num].SubItems.Add("Виконано");
				this.m_b++;
			}
			else
			{
				x.Items[num].ImageIndex = 1;
				x.Items[num].ForeColor = Color.Red;
				x.Items[num].SubItems.Add("Не виконано");
			}
		}
		string text = "";
		switch (this.m_b)
		{
		case 0:
			text = "балів";
			break;
		case 1:
			text = "бал";
			break;
		case 2:
			text = "бала";
			break;
		case 3:
			text = "бала";
			break;
		case 4:
			text = "бала";
			break;
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
			text = "балів";
			break;
		}
		ab.Text = "Ваш результат: " + this.m_b.ToString(CultureInfo.InvariantCulture) + " " + text;
		c();
		ad.Start();
		ae.Start();
		af.Start();
	}

	private void e(object A_0, EventArgs A_1)
	{
		Close();
	}

	private void c()
	{
		m = CreateGraphics();
		n = new Pen(Color.FromArgb(255, 250, 250, 250));
		o = new Pen(Color.FromArgb(255, 100, 100, 250));
		p = new Pen(Color.FromArgb(255, 250, 100, 100));
		q = new Font("Arial", 24f);
		r = new SolidBrush(Color.FromArgb(255, 250, 250, 250));
		s = new SolidBrush(Color.FromArgb(255, 50, 50, 250));
		t = new SolidBrush(Color.FromArgb(255, 250, 50, 50));
		u = new StringFormat();
		this.m_c = 10;
		this.m_d = 50;
		this.m_e = 130;
		f = 10;
		g = 250;
		h = 70;
		i = 400;
		j = 60;
		k = 800;
		m_l = 80;
	}

	private void b()
	{
		int num = 0;
		string text = "Нуль балів";
		int[] array = this.m_a.o;
		foreach (int num3 in array)
		{
			if (num3 - this.m_a.q == this.m_a.p)
			{
				num--;
			}
		}
		if (num * -1 != this.m_b)
		{
			num = (this.m_b = 0);
			m obj = this.m_a;
			bool[] array2 = new bool[5];
			obj.r = array2;
			d();
			ad.Stop();
			ae.Stop();
			af.Stop();
		}
		switch (num)
		{
		case 0:
			text = "Нуль балів";
			break;
		case -1:
			text = "Один бал";
			break;
		case -2:
			text = "Два бала";
			break;
		case -3:
			text = "Три бала";
			break;
		case -4:
			text = "Чотири бала";
			break;
		case -5:
			text = "П'ять балів";
			break;
		case -6:
			text = "Шість балів";
			break;
		case -7:
			text = "Сім балів";
			break;
		case -8:
			text = "Вісім балів";
			break;
		case -9:
			text = "Дев'ять балів";
			break;
		case -10:
			text = "Десять балів";
			break;
		}
		m.DrawString(text, q, Brushes.Yellow, 294f, 364f, u);
		m.DrawString(text, q, Brushes.Blue, 292f, 362f, u);
	}

	private void d(object A_0, EventArgs A_1)
	{
		Point[] points = new Point[5]
		{
			new Point(this.m_c, this.m_d),
			new Point(this.m_e, f++),
			new Point(g, h += 2),
			new Point(i, j += 4),
			new Point(k, m_l += 10)
		};
		m.DrawCurve(Pens.Yellow, points, 0.5f);
		Point[] points2 = new Point[5]
		{
			new Point(this.m_c + 50, this.m_d),
			new Point(this.m_e + 50, f++),
			new Point(g + 50, h += 2),
			new Point(i + 50, j += 4),
			new Point(k + 50, m_l += 10)
		};
		m.DrawCurve(Pens.Blue, points2, 0.5f);		
	}

	private void c(object A_0, EventArgs A_1)
	{
		Refresh();
		c();
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		ad.Stop();
		ae.Stop();
		af.Stop();
	}

	private void b(object A_0, EventArgs A_1)
	{
		ae.Stop();
		Refresh();
		c();
		ae.Start();
	}

	private void a(object A_0, EventArgs A_1)
	{
		b();
	}

	protected override void Dispose(bool disposing)
	{
		s.Dispose();
		o.Dispose();
		t.Dispose();
		p.Dispose();
		r.Dispose();
		n.Dispose();
		q.Dispose();
		u.Dispose();
		if (disposing && v != null)
		{
			v.Dispose();
		}
		base.Dispose(disposing);
	}

	private void a()
	{
		v = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(l));
		w = new Label();
		x = new ListView();
		y = new ColumnHeader();
		z = new ColumnHeader();
		aa = new ColumnHeader();
		ag = new ImageList(v);
		ab = new Label();
		ac = new Button();
		ad = new Timer(v);
		ae = new Timer(v);
		af = new Timer(v);
		SuspendLayout();
		w.AutoSize = true;
		w.Font = new Font("Verdana", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		w.ForeColor = Color.White;
		w.Location = new Point(210, 20);
		w.Name = "VerhLabel";
		w.Size = new Size(371, 25);
		w.TabIndex = 0;
		w.Text = "Результат виконаних завдань";
		x.Columns.AddRange(new ColumnHeader[3] { y, z, aa });
		x.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		x.ForeColor = Color.Black;
		x.FullRowSelect = true;
		x.Location = new Point(12, 62);
		x.MultiSelect = false;
		x.Name = "Result_list";
		x.ShowItemToolTips = true;
		x.Size = new Size(769, 252);
		x.SmallImageList = ag;
		x.TabIndex = 0;
		x.UseCompatibleStateImageBehavior = false;
		x.View = View.Details;
		y.Text = "     Розділ";
		y.Width = 110;
		z.Text = "Завдання";
		z.Width = 515;
		aa.Text = "Результат";
		aa.Width = 135;
		ag.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("Result_image.ImageStream");
		ag.TransparentColor = Color.Transparent;
		ag.Images.SetKeyName(0, "Apply.png");
		ag.Images.SetKeyName(1, "Cancel.png");
		ab.BackColor = Color.DimGray;
		ab.Font = new Font("Verdana", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		ab.ForeColor = Color.White;
		ab.Location = new Point(235, 314);
		ab.Name = "ResultLabel";
		ab.Size = new Size(320, 33);
		ab.TabIndex = 20;
		ab.Text = "label2";
		ab.TextAlign = ContentAlignment.MiddleCenter;
		ac.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		ac.Location = new Point(340, 420);
		ac.Name = "OkBut";
		ac.Size = new Size(110, 32);
		ac.TabIndex = 1;
		ac.Text = "ОК";
		ac.UseVisualStyleBackColor = true;
		ac.Click += e;
		ad.Interval = 50;
		ad.Tick += d;
		ae.Interval = 10000;
		ae.Tick += c;
		af.Interval = 1000;
		af.Tick += a;
		base.AutoScaleDimensions = new SizeF(10f, 18f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.DimGray;
		base.ClientSize = new Size(790, 463);
		base.Controls.Add(ac);
		base.Controls.Add(ab);
		base.Controls.Add(x);
		base.Controls.Add(w);
		Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 204);
		ForeColor = Color.Black;
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "Result_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "MyBIOS v4.3.0.8";
		base.FormClosing += a;
		base.LocationChanged += b;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
