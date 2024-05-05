using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class v : Form
{
	private const int m_a = 3;

	private IContainer m_b;

	private PictureBox m_c;

	private PictureBox m_d;

	private Panel e;

	private Panel f;

	private PictureBox g;

	private Panel h;

	private Panel i;

	private Panel j;

	private Panel k;

	private Panel l;

	private Panel m;

	private Label n;

	private Label o;

	private Label p;

	private Label q;

	private Label r;

	private Label s;

	private Label t;

	private Label u;

	private Label m_v;

	private Label w;

	private Label x;

	private Label y;

	private u z;

	private ac aa;

	private int ab;

	private bool ac = true;

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_b != null)
		{
			this.m_b.Dispose();
		}
		base.Dispose(disposing);
	}

	private void d()
	{
		this.m_c = new PictureBox();
		this.m_d = new PictureBox();
		e = new Panel();
		w = new Label();
		u = new Label();
		m_v = new Label();
		p = new Label();
		q = new Label();
		r = new Label();
		s = new Label();
		t = new Label();
		o = new Label();
		n = new Label();
		m = new Panel();
		f = new Panel();
		x = new Label();
		y = new Label();
		g = new PictureBox();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		((ISupportInitialize)this.m_c).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		e.SuspendLayout();
		f.SuspendLayout();
		((ISupportInitialize)g).BeginInit();
		SuspendLayout();
		this.m_c.Dock = DockStyle.Top;
		this.m_c.Image = Resources.ShapkaAll;
		this.m_c.Location = new Point(0, 0);
		this.m_c.Name = "Shapka";
		this.m_c.Size = new Size(1280, 35);
		this.m_c.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_c.TabIndex = 0;
		this.m_c.TabStop = false;
		this.m_d.Dock = DockStyle.Top;
		this.m_d.Image = Resources.AdvancedOnly;
		this.m_d.Location = new Point(0, 35);
		this.m_d.Name = "VerhMenu";
		this.m_d.Size = new Size(1280, 35);
		this.m_d.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_d.TabIndex = 1;
		this.m_d.TabStop = false;
		e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		e.AutoScroll = true;
		e.BackColor = Color.FromArgb(190, 190, 190);
		e.Controls.Add(w);
		e.Controls.Add(u);
		e.Controls.Add(m_v);
		e.Controls.Add(p);
		e.Controls.Add(q);
		e.Controls.Add(r);
		e.Controls.Add(s);
		e.Controls.Add(t);
		e.Controls.Add(o);
		e.Controls.Add(n);
		e.Controls.Add(m);
		e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		e.ForeColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(12, 92);
		e.Name = "Lev_Panel";
		e.Size = new Size(868, 877);
		e.TabIndex = 2;
		w.Location = new Point(700, 233);
		w.Name = "End";
		w.Size = new Size(126, 37);
		w.TabIndex = 44;
		u.Anchor = AnchorStyles.Top;
		u.AutoSize = true;
		u.Location = new Point(460, 191);
		u.Name = "PEGPortForcex1_Value";
		u.Size = new Size(97, 34);
		u.TabIndex = 43;
		u.Text = "label1";
		m_v.AutoSize = true;
		m_v.Location = new Point(42, 191);
		m_v.Name = "PEGPortForcex1";
		m_v.Size = new Size(269, 34);
		m_v.TabIndex = 42;
		m_v.Text = "PEG Port Force x1";
		p.Anchor = AnchorStyles.Top;
		p.AutoSize = true;
		p.Location = new Point(460, 157);
		p.Name = "PEGPortControl_Value";
		p.Size = new Size(97, 34);
		p.TabIndex = 41;
		p.Text = "label1";
		q.AutoSize = true;
		q.Location = new Point(22, 157);
		q.Name = "PEGPortControl";
		q.Size = new Size(254, 34);
		q.TabIndex = 40;
		q.Text = "PEG Port Control";
		r.Anchor = AnchorStyles.Top;
		r.AutoSize = true;
		r.Location = new Point(460, 123);
		r.Name = "InitiateGraphicAdapter_Value";
		r.Size = new Size(97, 34);
		r.TabIndex = 39;
		r.Text = "label1";
		s.AutoSize = true;
		s.Location = new Point(22, 123);
		s.Name = "InitiateGraphicAdapter";
		s.Size = new Size(342, 34);
		s.TabIndex = 38;
		s.Text = "Initiate Graphic Adapter";
		t.Anchor = AnchorStyles.Top;
		t.AutoSize = true;
		t.Location = new Point(460, 89);
		t.Name = "MemoryRemapFeature_Value";
		t.Size = new Size(97, 34);
		t.TabIndex = 37;
		t.Text = "label1";
		o.AutoSize = true;
		o.Location = new Point(22, 89);
		o.Name = "MemoryRemapFeature";
		o.Size = new Size(345, 34);
		o.TabIndex = 36;
		o.Text = "Memory Remap Feature";
		n.AutoSize = true;
		n.ForeColor = Color.Black;
		n.Location = new Point(22, 17);
		n.Name = "NorthBridgeChipsetConfiguration_shapka";
		n.Size = new Size(507, 34);
		n.TabIndex = 35;
		n.Text = "North Bridge Chipset Configuration";
		m.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		m.BackColor = Color.FromArgb(27, 35, 165);
		m.Location = new Point(18, 68);
		m.Name = "Goriz_1";
		m.Size = new Size(828, 2);
		m.TabIndex = 1;
		f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = true;
		f.Controls.Add(x);
		f.Controls.Add(y);
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(884, 92);
		f.Name = "Prav_Panel";
		f.Size = new Size(382, 877);
		f.TabIndex = 3;
		x.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		x.Location = new Point(6, 590);
		x.Name = "Help_Niz";
		x.Size = new Size(372, 250);
		x.TabIndex = 1;
		y.Location = new Point(6, 15);
		y.Name = "Help_Verh";
		y.Size = new Size(372, 470);
		y.TabIndex = 0;
		g.Dock = DockStyle.Bottom;
		g.Image = Resources.NizAll;
		g.Location = new Point(0, 989);
		g.Name = "Niz";
		g.Size = new Size(1280, 35);
		g.SizeMode = PictureBoxSizeMode.StretchImage;
		g.TabIndex = 4;
		g.TabStop = false;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		h.BackColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(10, 90);
		h.Name = "Goriz1";
		h.Size = new Size(1260, 2);
		h.TabIndex = 0;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		i.BackColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(10, 90);
		i.Name = "Vert1";
		i.Size = new Size(4, 879);
		i.TabIndex = 0;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.BackColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(880, 90);
		j.Name = "Vert2";
		j.Size = new Size(4, 879);
		j.TabIndex = 1;
		k.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		k.BackColor = Color.FromArgb(27, 35, 165);
		k.Location = new Point(10, 969);
		k.Name = "Goriz2";
		k.Size = new Size(1260, 2);
		k.TabIndex = 1;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		l.BackColor = Color.FromArgb(27, 35, 165);
		l.Location = new Point(1266, 90);
		l.Name = "Vert3";
		l.Size = new Size(4, 879);
		l.TabIndex = 2;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(k);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(this.m_d);
		base.Controls.Add(this.m_c);
		base.Controls.Add(l);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(e);
		base.Controls.Add(f);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Advanced_Chipset_NorthBridgeConfiguration_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Advanced_Chipset_NorthBridgeConfiguration_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)this.m_c).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		e.ResumeLayout(performLayout: false);
		e.PerformLayout();
		f.ResumeLayout(performLayout: false);
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
	}

	public v(u A_0)
	{
		z = A_0;
		d();
		c();
		b();
	}

	private void c()
	{
		if (z.ih == "Disabled")
		{
			m_v.Visible = false;
			u.Visible = false;
		}
		else
		{
			m_v.Visible = true;
			u.Visible = true;
		}
		t.Text = z.k(z.ib);
		r.Text = z.k(z.ie);
		p.Text = z.k(z.ih);
		u.Text = z.k(z.ik);
		x.Text = z.o;
	}

	private void b()
	{
		if (z.ih == "Disabled" && ab == 3)
		{
			ab = 2;
		}
		foreach (Control control in e.Controls)
		{
			if (control.Name != "NorthBridgeChipsetConfiguration_shapka")
			{
				control.ForeColor = z.g;
			}
		}
		switch (ab)
		{
		case 0:
			y.Text = z.id;
			o.ForeColor = Color.White;
			t.ForeColor = Color.White;
			break;
		case 1:
			y.Text = z.ig;
			s.ForeColor = Color.White;
			r.ForeColor = Color.White;
			break;
		case 2:
			y.Text = z.ij;
			q.ForeColor = Color.White;
			p.ForeColor = Color.White;
			break;
		case 3:
			y.Text = z.im;
			m_v.ForeColor = Color.White;
			u.ForeColor = Color.White;
			break;
		}
	}

	private void a()
	{
		switch (ab)
		{
		case 0:
			aa = new ac(z, z.ib, z.ic);
			aa.ShowDialog();
			z.ib = z.m;
			break;
		case 1:
			aa = new ac(z, z.ie, z.@if);
			aa.ShowDialog();
			z.ie = z.m;
			break;
		case 2:
			aa = new ac(z, z.ih, z.ii);
			aa.ShowDialog();
			z.ih = z.m;
			break;
		case 3:
			aa = new ac(z, z.ik, z.il);
			aa.ShowDialog();
			z.ik = z.m;
			break;
		}
		c();
	}

	private void a(bool A_0)
	{
		switch (ab)
		{
		case 0:
			z.k(ref z.ib, z.ic, A_0);
			break;
		case 1:
			z.k(ref z.ie, z.@if, A_0);
			break;
		case 2:
			z.k(ref z.ih, z.ii, A_0);
			break;
		case 3:
			z.k(ref z.ik, z.il, A_0);
			break;
		}
		c();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			ac = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Up && ab > 0)
		{
			ab--;
			b();
		}
		else if (A_1.KeyCode == Keys.Down && ab < 3)
		{
			ab++;
			b();
		}
		else if (A_1.KeyCode == Keys.Add)
		{
			a(A_0: true);
		}
		else if (A_1.KeyCode == Keys.Subtract)
		{
			a(A_0: false);
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			a();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			ab = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			ab = 3;
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			z.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			z.na();
			c();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			z.nd();
			c();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			z.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = ac;
	}
}
