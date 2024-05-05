using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class j : Form
{
	private IContainer m_a;

	private PictureBox m_b;

	private PictureBox c;

	private Panel d;

	private Panel e;

	private PictureBox f;

	private Panel g;

	private Panel h;

	private Panel i;

	private Panel m_j;

	private Panel k;

	private Label l;

	private Label m;

	private Label n;

	private Label o;

	private Label p;

	private Label q;

	private Label r;

	private Label s;

	private Label t;

	private Label u;

	private Label v;

	private Label w;

	private Label x;

	private Label y;

	private Label z;

	private Label aa;

	private u ab;

	private bool ac = true;

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		base.Dispose(disposing);
	}

	private void b()
	{
		this.m_b = new PictureBox();
		c = new PictureBox();
		d = new Panel();
		u = new Label();
		v = new Label();
		w = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		t = new Label();
		m = new Label();
		n = new Label();
		o = new Label();
		p = new Label();
		q = new Label();
		r = new Label();
		s = new Label();
		l = new Label();
		e = new Panel();
		aa = new Label();
		f = new PictureBox();
		g = new Panel();
		h = new Panel();
		i = new Panel();
		m_j = new Panel();
		k = new Panel();
		((ISupportInitialize)this.m_b).BeginInit();
		((ISupportInitialize)c).BeginInit();
		d.SuspendLayout();
		e.SuspendLayout();
		((ISupportInitialize)f).BeginInit();
		SuspendLayout();
		this.m_b.Dock = DockStyle.Top;
		this.m_b.Image = Resources.ShapkaAll;
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "Shapka";
		this.m_b.Size = new Size(1280, 35);
		this.m_b.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_b.TabIndex = 0;
		this.m_b.TabStop = false;
		c.Dock = DockStyle.Top;
		c.Image = Resources.MainOnly;
		c.Location = new Point(0, 35);
		c.Name = "VerhMenu";
		c.Size = new Size(1280, 35);
		c.SizeMode = PictureBoxSizeMode.StretchImage;
		c.TabIndex = 1;
		c.TabStop = false;
		d.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		d.AutoScroll = true;
		d.BackColor = Color.FromArgb(190, 190, 190);
		d.Controls.Add(u);
		d.Controls.Add(v);
		d.Controls.Add(w);
		d.Controls.Add(x);
		d.Controls.Add(y);
		d.Controls.Add(z);
		d.Controls.Add(t);
		d.Controls.Add(m);
		d.Controls.Add(n);
		d.Controls.Add(o);
		d.Controls.Add(p);
		d.Controls.Add(q);
		d.Controls.Add(r);
		d.Controls.Add(s);
		d.Controls.Add(l);
		d.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		d.ForeColor = Color.FromArgb(27, 35, 165);
		d.Location = new Point(12, 92);
		d.Name = "Lev_Panel";
		d.Size = new Size(868, 877);
		d.TabIndex = 2;
		u.AutoSize = true;
		u.ForeColor = Color.FromArgb(64, 64, 64);
		u.Location = new Point(172, 417);
		u.Name = "Available_VALUE";
		u.Size = new Size(97, 34);
		u.TabIndex = 14;
		u.Text = "label6";
		v.AutoSize = true;
		v.ForeColor = Color.FromArgb(64, 64, 64);
		v.Location = new Point(172, 305);
		v.Name = "Count_VALUE";
		v.Size = new Size(97, 34);
		v.TabIndex = 13;
		v.Text = "label5";
		w.AutoSize = true;
		w.ForeColor = Color.FromArgb(64, 64, 64);
		w.Location = new Point(172, 271);
		w.Name = "Speed_VALUE";
		w.Size = new Size(97, 34);
		w.TabIndex = 12;
		w.Text = "label4";
		x.AutoSize = true;
		x.ForeColor = Color.FromArgb(64, 64, 64);
		x.Location = new Point(172, 199);
		x.Name = "Type_VALUE";
		x.Size = new Size(97, 34);
		x.TabIndex = 11;
		x.Text = "label3";
		y.AutoSize = true;
		y.ForeColor = Color.FromArgb(64, 64, 64);
		y.Location = new Point(172, 91);
		y.Name = "BuildDate_VALUE";
		y.Size = new Size(97, 34);
		y.TabIndex = 10;
		y.Text = "label2";
		z.AutoSize = true;
		z.ForeColor = Color.FromArgb(64, 64, 64);
		z.Location = new Point(172, 57);
		z.Name = "Version_VALUE";
		z.Size = new Size(97, 34);
		z.TabIndex = 9;
		z.Text = "label1";
		t.AutoSize = true;
		t.ForeColor = Color.FromArgb(64, 64, 64);
		t.Location = new Point(22, 417);
		t.Name = "Available";
		t.Size = new Size(140, 34);
		t.TabIndex = 8;
		t.Text = "Available";
		m.AutoSize = true;
		m.ForeColor = Color.FromArgb(64, 64, 64);
		m.Location = new Point(22, 305);
		m.Name = "Count";
		m.Size = new Size(100, 34);
		m.TabIndex = 7;
		m.Text = "Count";
		n.AutoSize = true;
		n.ForeColor = Color.FromArgb(64, 64, 64);
		n.Location = new Point(22, 271);
		n.Name = "Speed";
		n.Size = new Size(102, 34);
		n.TabIndex = 6;
		n.Text = "Speed";
		o.AutoSize = true;
		o.ForeColor = Color.FromArgb(64, 64, 64);
		o.Location = new Point(22, 199);
		o.Name = "Type";
		o.Size = new Size(81, 34);
		o.TabIndex = 5;
		o.Text = "Type";
		p.AutoSize = true;
		p.ForeColor = Color.FromArgb(64, 64, 64);
		p.Location = new Point(22, 91);
		p.Name = "BuildDate";
		p.Size = new Size(158, 34);
		p.TabIndex = 4;
		p.Text = "Build Date";
		q.AutoSize = true;
		q.ForeColor = Color.FromArgb(64, 64, 64);
		q.Location = new Point(22, 57);
		q.Name = "Version";
		q.Size = new Size(119, 34);
		q.TabIndex = 3;
		q.Text = "Version";
		r.AutoSize = true;
		r.ForeColor = Color.Black;
		r.Location = new Point(22, 383);
		r.Name = "SystemMemory";
		r.Size = new Size(238, 34);
		r.TabIndex = 2;
		r.Text = "System Memory";
		s.AutoSize = true;
		s.ForeColor = Color.Black;
		s.Location = new Point(22, 165);
		s.Name = "Processor";
		s.Size = new Size(156, 34);
		s.TabIndex = 1;
		s.Text = "Processor";
		l.AutoSize = true;
		l.ForeColor = Color.Black;
		l.Location = new Point(22, 23);
		l.Name = "ASUSBIOS";
		l.Size = new Size(170, 34);
		l.TabIndex = 0;
		l.Text = "ASUS BIOS";
		e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		e.AutoScroll = true;
		e.Controls.Add(aa);
		e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		e.ForeColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(884, 92);
		e.Name = "Prav_Panel";
		e.Size = new Size(382, 877);
		e.TabIndex = 3;
		aa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		aa.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		aa.ForeColor = Color.FromArgb(27, 35, 165);
		aa.Location = new Point(6, 590);
		aa.Name = "Help_Niz";
		aa.Size = new Size(372, 250);
		aa.TabIndex = 0;
		f.Dock = DockStyle.Bottom;
		f.Image = Resources.NizAll;
		f.Location = new Point(0, 989);
		f.Name = "Niz";
		f.Size = new Size(1280, 35);
		f.SizeMode = PictureBoxSizeMode.StretchImage;
		f.TabIndex = 4;
		f.TabStop = false;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		g.BackColor = Color.FromArgb(27, 35, 165);
		g.Location = new Point(10, 90);
		g.Name = "Goriz1";
		g.Size = new Size(1260, 2);
		g.TabIndex = 0;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		h.BackColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(10, 90);
		h.Name = "Vert1";
		h.Size = new Size(4, 879);
		h.TabIndex = 0;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		i.BackColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(880, 90);
		i.Name = "Vert2";
		i.Size = new Size(4, 879);
		i.TabIndex = 1;
		m_j.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		m_j.BackColor = Color.FromArgb(27, 35, 165);
		m_j.Location = new Point(10, 969);
		m_j.Name = "Goriz2";
		m_j.Size = new Size(1260, 2);
		m_j.TabIndex = 1;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		k.BackColor = Color.FromArgb(27, 35, 165);
		k.Location = new Point(1266, 90);
		k.Name = "Vert3";
		k.Size = new Size(4, 879);
		k.TabIndex = 2;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(m_j);
		base.Controls.Add(g);
		base.Controls.Add(f);
		base.Controls.Add(c);
		base.Controls.Add(this.m_b);
		base.Controls.Add(k);
		base.Controls.Add(i);
		base.Controls.Add(h);
		base.Controls.Add(d);
		base.Controls.Add(e);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Main_SystemInformation_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Main_SystemInformation_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)this.m_b).EndInit();
		((ISupportInitialize)c).EndInit();
		d.ResumeLayout(performLayout: false);
		d.PerformLayout();
		e.ResumeLayout(performLayout: false);
		((ISupportInitialize)f).EndInit();
		ResumeLayout(performLayout: false);
	}

	public j(u A_0)
	{
		ab = A_0;
		b();
		a();
	}

	private void a()
	{
		z.Text = ": " + ab.d1;
		y.Text = ": " + ab.d2;
		x.Text = ": " + ab.d3;
		w.Text = ": " + ab.d4;
		v.Text = ": " + ab.d5;
		u.Text = ": " + ab.d6;
		aa.Text = ab.q;
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			ac = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			ab.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			ab.na();
			a();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			ab.nd();
			a();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			ab.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = ac;
	}
}
