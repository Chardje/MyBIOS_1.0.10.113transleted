using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class c : Form
{
	private const int m_a = 5;

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

	private Label v;

	private Label w;

	private Label x;

	private Label y;

	private Label z;

	private Label aa;

	private Label ab;

	private Label ac;

	private Label ad;

	private Label ae;

	private u af;

	private ac ag;

	private int ah;

	private bool ai = true;

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
		ac = new Label();
		w = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		aa = new Label();
		ab = new Label();
		v = new Label();
		q = new Label();
		r = new Label();
		s = new Label();
		t = new Label();
		u = new Label();
		p = new Label();
		o = new Label();
		n = new Label();
		m = new Panel();
		f = new Panel();
		ad = new Label();
		ae = new Label();
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
		e.Controls.Add(ac);
		e.Controls.Add(w);
		e.Controls.Add(x);
		e.Controls.Add(y);
		e.Controls.Add(z);
		e.Controls.Add(aa);
		e.Controls.Add(ab);
		e.Controls.Add(v);
		e.Controls.Add(q);
		e.Controls.Add(r);
		e.Controls.Add(s);
		e.Controls.Add(t);
		e.Controls.Add(u);
		e.Controls.Add(p);
		e.Controls.Add(o);
		e.Controls.Add(n);
		e.Controls.Add(m);
		e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		e.ForeColor = Color.FromArgb(27, 35, 165);
		e.Location = new Point(12, 92);
		e.Name = "Lev_Panel";
		e.Size = new Size(868, 877);
		e.TabIndex = 2;
		ac.Location = new Point(700, 384);
		ac.Name = "End";
		ac.Size = new Size(126, 37);
		ac.TabIndex = 50;
		w.Anchor = AnchorStyles.Top;
		w.AutoSize = true;
		w.Location = new Point(449, 347);
		w.Name = "LegacyUSBSupport_Value";
		w.Size = new Size(97, 34);
		w.TabIndex = 49;
		w.Text = "label6";
		x.Anchor = AnchorStyles.Top;
		x.AutoSize = true;
		x.Location = new Point(449, 313);
		x.Name = "Port6460Emulation_Value";
		x.Size = new Size(97, 34);
		x.TabIndex = 48;
		x.Text = "label5";
		y.Anchor = AnchorStyles.Top;
		y.AutoSize = true;
		y.Location = new Point(449, 279);
		y.Name = "BIOSEHCIHandoff_Value";
		y.Size = new Size(97, 34);
		y.TabIndex = 47;
		y.Text = "label4";
		z.Anchor = AnchorStyles.Top;
		z.AutoSize = true;
		z.Location = new Point(449, 245);
		z.Name = "USB20ControllerMode_Value";
		z.Size = new Size(97, 34);
		z.TabIndex = 46;
		z.Text = "label3";
		aa.Anchor = AnchorStyles.Top;
		aa.AutoSize = true;
		aa.Location = new Point(449, 211);
		aa.Name = "USB20Controller_Value";
		aa.Size = new Size(97, 34);
		aa.TabIndex = 45;
		aa.Text = "label2";
		ab.Anchor = AnchorStyles.Top;
		ab.AutoSize = true;
		ab.Location = new Point(449, 177);
		ab.Name = "USBFunctions_Value";
		ab.Size = new Size(97, 34);
		ab.TabIndex = 44;
		ab.Text = "label1";
		v.AutoSize = true;
		v.Location = new Point(22, 347);
		v.Name = "LegacyUSBSupport";
		v.Size = new Size(303, 34);
		v.TabIndex = 43;
		v.Text = "Legacy USB Support";
		q.AutoSize = true;
		q.Location = new Point(22, 313);
		q.Name = "Port6460Emulation";
		q.Size = new Size(302, 34);
		q.TabIndex = 42;
		q.Text = "Port 64/60 Emulation";
		r.AutoSize = true;
		r.Location = new Point(22, 279);
		r.Name = "BIOSEHCIHandoff";
		r.Size = new Size(290, 34);
		r.TabIndex = 41;
		r.Text = "BIOS EHCI Hand-off";
		s.AutoSize = true;
		s.Location = new Point(22, 245);
		s.Name = "USB20ControllerMode";
		s.Size = new Size(355, 34);
		s.TabIndex = 40;
		s.Text = "USB 2.0 Controller Mode";
		t.AutoSize = true;
		t.Location = new Point(22, 211);
		t.Name = "USB20Controller";
		t.Size = new Size(270, 34);
		t.TabIndex = 39;
		t.Text = "USB 2.0 Controller";
		u.AutoSize = true;
		u.Location = new Point(22, 177);
		u.Name = "USBFunctions";
		u.Size = new Size(223, 34);
		u.TabIndex = 38;
		u.Text = "USB Functions";
		p.AutoSize = true;
		p.ForeColor = Color.FromArgb(64, 64, 64);
		p.Location = new Point(67, 122);
		p.Name = "USBDevicesEnabled_INFO_Value";
		p.Size = new Size(97, 34);
		p.TabIndex = 37;
		p.Text = "label1";
		o.AutoSize = true;
		o.ForeColor = Color.Black;
		o.Location = new Point(22, 88);
		o.Name = "USBDevicesEnabled";
		o.Size = new Size(332, 34);
		o.TabIndex = 36;
		o.Text = "USB Devices Enabled :";
		n.AutoSize = true;
		n.ForeColor = Color.Black;
		n.Location = new Point(22, 17);
		n.Name = "USBConfiguration_shapka";
		n.Size = new Size(275, 34);
		n.TabIndex = 35;
		n.Text = "USB Configuration";
		m.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		m.BackColor = Color.FromArgb(27, 35, 165);
		m.Location = new Point(18, 68);
		m.Name = "Goriz_1";
		m.Size = new Size(828, 2);
		m.TabIndex = 1;
		f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = true;
		f.Controls.Add(ad);
		f.Controls.Add(ae);
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(884, 92);
		f.Name = "Prav_Panel";
		f.Size = new Size(382, 877);
		f.TabIndex = 3;
		ad.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ad.Location = new Point(6, 590);
		ad.Name = "Help_Niz";
		ad.Size = new Size(372, 250);
		ad.TabIndex = 1;
		ae.Location = new Point(6, 15);
		ae.Name = "Help_Verh";
		ae.Size = new Size(372, 470);
		ae.TabIndex = 0;
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
		base.Name = "Advanced_USBConfiguration_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Advanced_USBConfiguration_Form";
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

	public c(u A_0)
	{
		af = A_0;
		d();
		cm();
		b();
	}

	private void cm()
	{
		int num = u.Location.X;
		int num2 = ab.Location.X;
		int num3 = 0;
		if (af.g5 == "Disabled" || af.hh == "Disabled")
		{
			num3 = s.Location.Y;
			s.Visible = false;
			z.Visible = false;
		}
		else
		{
			num3 = s.Location.Y + 34;
			s.Visible = true;
			z.Visible = true;
		}
		r.Location = new Point(num, num3);
		y.Location = new Point(num2, num3);
		q.Location = new Point(num, num3 += 34);
		x.Location = new Point(num2, num3);
		v.Location = new Point(num, num3 += 34);
		w.Location = new Point(num2, num3);
		if (af.g2 == "Disabled")
		{
			t.Visible = false;
			aa.Visible = false;
			s.Visible = false;
			z.Visible = false;
			r.Visible = false;
			y.Visible = false;
			q.Visible = false;
			x.Visible = false;
			v.Visible = false;
			w.Visible = false;
		}
		else
		{
			t.Visible = true;
			aa.Visible = true;
			if (af.g5 != "Disabled" && af.hh != "Disabled")
			{
				s.Visible = true;
				z.Visible = true;
			}
			r.Visible = true;
			y.Visible = true;
			q.Visible = true;
			x.Visible = true;
			v.Visible = true;
			w.Visible = true;
		}
		p.Text = af.g1;
		ab.Text = af.k(af.g2);
		aa.Text = af.k(af.g5);
		z.Text = af.k(af.g8);
		y.Text = af.k(af.hb);
		x.Text = af.k(af.he);
		w.Text = af.k(af.hh);
		ad.Text = af.o;
	}

	private void b()
	{
		if (af.g2 == "Disabled")
		{
			ah = 0;
			return;
		}
		u.ForeColor = af.g;
		ab.ForeColor = af.g;
		t.ForeColor = af.g;
		aa.ForeColor = af.g;
		s.ForeColor = af.g;
		z.ForeColor = af.g;
		r.ForeColor = af.g;
		y.ForeColor = af.g;
		q.ForeColor = af.g;
		x.ForeColor = af.g;
		v.ForeColor = af.g;
		w.ForeColor = af.g;
		switch (ah)
		{
		case 0:
			ae.Text = af.g4;
			u.ForeColor = Color.White;
			ab.ForeColor = Color.White;
			break;
		case 1:
			ae.Text = af.g7;
			t.ForeColor = Color.White;
			aa.ForeColor = Color.White;
			break;
		case 2:
			ae.Text = af.ha;
			s.ForeColor = Color.White;
			z.ForeColor = Color.White;
			break;
		case 3:
			ae.Text = af.hd;
			r.ForeColor = Color.White;
			y.ForeColor = Color.White;
			break;
		case 4:
			ae.Text = af.hg;
			q.ForeColor = Color.White;
			x.ForeColor = Color.White;
			break;
		case 5:
			ae.Text = af.hj;
			v.ForeColor = Color.White;
			w.ForeColor = Color.White;
			break;
		}
	}

	private void a()
	{
		switch (ah)
		{
		case 0:
			ag = new ac(af, af.g2, af.g3);
			ag.ShowDialog();
			af.g2 = af.m;
			break;
		case 1:
			ag = new ac(af, af.g5, af.g6);
			ag.ShowDialog();
			af.g5 = af.m;
			break;
		case 2:
			ag = new ac(af, af.g8, af.g9);
			ag.ShowDialog();
			af.g8 = af.m;
			break;
		case 3:
			ag = new ac(af, af.hb, af.hc);
			ag.ShowDialog();
			af.hb = af.m;
			break;
		case 4:
			ag = new ac(af, af.he, af.hf);
			ag.ShowDialog();
			af.he = af.m;
			break;
		case 5:
			ag = new ac(af, af.hh, af.hi);
			ag.ShowDialog();
			af.hh = af.m;
			break;
		}
		cm();
	}

	private void a(bool A_0)
	{
		switch (ah)
		{
		case 0:
			af.k(ref af.g2, af.g3, A_0);
			break;
		case 1:
			af.k(ref af.g5, af.g6, A_0);
			break;
		case 2:
			af.k(ref af.g8, af.g9, A_0);
			break;
		case 3:
			af.k(ref af.hb, af.hc, A_0);
			break;
		case 4:
			af.k(ref af.he, af.hf, A_0);
			break;
		case 5:
			af.k(ref af.hh, af.hi, A_0);
			break;
		}
		cm();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			ai = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Up && ah > 0)
		{
			ah--;
			if ((af.g5 == "Disabled" || af.hh == "Disabled") && ah == 2)
			{
				ah = 1;
			}
			b();
		}
		else if (A_1.KeyCode == Keys.Down && ah < 5)
		{
			ah++;
			if ((af.g5 == "Disabled" || af.hh == "Disabled") && ah == 2)
			{
				ah = 3;
			}
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
			ah = 0;
			b();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			ah = 5;
			b();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			af.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			af.na();
			cm();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			af.nd();
			cm();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			af.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = ai;
	}
}
