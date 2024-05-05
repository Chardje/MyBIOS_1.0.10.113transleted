using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class t : Form
{
	private const int m_a = 7;

	private u m_b;

	private ac m_c;

	private int m_d;

	private bool e = true;

	private IContainer f;

	private PictureBox g;

	private PictureBox h;

	private Panel i;

	private Panel j;

	private PictureBox k;

	private Panel l;

	private Panel m;

	private Panel n;

	private Panel o;

	private Panel p;

	private Panel q;

	private Label r;

	private Label s;

	private Label m_t;

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

	private Label af;

	private Label ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private Label ak;

	public t(u A_0)
	{
		this.m_b = A_0;
		a();
		d();
		c();
	}

	private void d()
	{
		int num = w.Location.X;
		int num2 = u.Location.X;
		int num3 = v.Location.X;
		int num4 = 0;
		if (this.m_b.io == "Disabled")
		{
			num4 = u.Location.Y;
			u.Visible = false;
			m_t.Visible = false;
		}
		else
		{
			num4 = u.Location.Y + 34;
			u.Visible = true;
			m_t.Visible = true;
		}
		s.Location = new Point(num, num4);
		ag.Location = new Point(num3, num4);
		af.Location = new Point(num, num4 += 34);
		ae.Location = new Point(num3, num4);
		ad.Location = new Point(num2, num4 += 34);
		ac.Location = new Point(num3, num4);
		if (this.m_b.ix == "Disabled")
		{
			num4 = ad.Location.Y;
			ad.Visible = false;
			ac.Visible = false;
		}
		else
		{
			num4 = ad.Location.Y + 34;
			ad.Visible = true;
			ac.Visible = true;
		}
		ab.Location = new Point(num, num4);
		aa.Location = new Point(num3, num4);
		z.Location = new Point(num2, num4 += 34);
		y.Location = new Point(num3, num4);
		if (this.m_b.i3 == "Disabled")
		{
			num4 = z.Location.Y;
			z.Visible = false;
			y.Visible = false;
		}
		else
		{
			num4 = z.Location.Y + 34;
			z.Visible = true;
			y.Visible = true;
		}
		x.Location = new Point(num, num4 += 34);
		ah.Location = new Point(num3, num4);
		v.Text = this.m_b.k(this.m_b.io);
		m_t.Text = this.m_b.k(this.m_b.ir);
		ag.Text = this.m_b.k(this.m_b.iu);
		ae.Text = this.m_b.k(this.m_b.ix);
		ac.Text = this.m_b.k(this.m_b.i0);
		aa.Text = this.m_b.k(this.m_b.i3);
		y.Text = this.m_b.k(this.m_b.i6);
		ah.Text = this.m_b.k(this.m_b.i9);
		aj.Text = this.m_b.o;
	}

	private void c()
	{
		foreach (Control control in i.Controls)
		{
			if (control.Name != "OnboardDeviceConfiguration_shapka")
			{
				control.ForeColor = this.m_b.g;
			}
		}
		switch (this.m_d)
		{
		case 0:
			ak.Text = this.m_b.iq;
			w.ForeColor = Color.White;
			v.ForeColor = Color.White;
			break;
		case 1:
			ak.Text = this.m_b.it;
			u.ForeColor = Color.White;
			m_t.ForeColor = Color.White;
			break;
		case 2:
			ak.Text = this.m_b.iw;
			s.ForeColor = Color.White;
			ag.ForeColor = Color.White;
			break;
		case 3:
			ak.Text = this.m_b.iz;
			af.ForeColor = Color.White;
			ae.ForeColor = Color.White;
			break;
		case 4:
			ak.Text = this.m_b.i2;
			ad.ForeColor = Color.White;
			ac.ForeColor = Color.White;
			break;
		case 5:
			ak.Text = this.m_b.i5;
			ab.ForeColor = Color.White;
			aa.ForeColor = Color.White;
			break;
		case 6:
			ak.Text = this.m_b.i8;
			z.ForeColor = Color.White;
			y.ForeColor = Color.White;
			break;
		case 7:
			ak.Text = this.m_b.jb;
			x.ForeColor = Color.White;
			ah.ForeColor = Color.White;
			break;
		}
	}

	private void b()
	{
		switch (this.m_d)
		{
		case 0:
			this.m_c = new ac(this.m_b, this.m_b.io, this.m_b.ip);
			this.m_c.ShowDialog();
			this.m_b.io = this.m_b.m;
			break;
		case 1:
			this.m_c = new ac(this.m_b, this.m_b.ir, this.m_b.@is);
			this.m_c.ShowDialog();
			this.m_b.ir = this.m_b.m;
			break;
		case 2:
			this.m_c = new ac(this.m_b, this.m_b.iu, this.m_b.iv);
			this.m_c.ShowDialog();
			this.m_b.iu = this.m_b.m;
			break;
		case 3:
			this.m_c = new ac(this.m_b, this.m_b.ix, this.m_b.iy);
			this.m_c.ShowDialog();
			this.m_b.ix = this.m_b.m;
			break;
		case 4:
			this.m_c = new ac(this.m_b, this.m_b.i0, this.m_b.i1);
			this.m_c.ShowDialog();
			this.m_b.i0 = this.m_b.m;
			break;
		case 5:
			this.m_c = new ac(this.m_b, this.m_b.i3, this.m_b.i4);
			this.m_c.ShowDialog();
			this.m_b.i3 = this.m_b.m;
			break;
		case 6:
			this.m_c = new ac(this.m_b, this.m_b.i6, this.m_b.i7);
			this.m_c.ShowDialog();
			this.m_b.i6 = this.m_b.m;
			break;
		case 7:
			this.m_c = new ac(this.m_b, this.m_b.i9, this.m_b.ja);
			this.m_c.ShowDialog();
			this.m_b.i9 = this.m_b.m;
			break;
		}
		d();
	}

	private void a(bool A_0)
	{
		switch (this.m_d)
		{
		case 0:
			this.m_b.k(ref this.m_b.io, this.m_b.ip, A_0);
			break;
		case 1:
			this.m_b.k(ref this.m_b.ir, this.m_b.@is, A_0);
			break;
		case 2:
			this.m_b.k(ref this.m_b.iu, this.m_b.iv, A_0);
			break;
		case 3:
			this.m_b.k(ref this.m_b.ix, this.m_b.iy, A_0);
			break;
		case 4:
			this.m_b.k(ref this.m_b.i0, this.m_b.i1, A_0);
			break;
		case 5:
			this.m_b.k(ref this.m_b.i3, this.m_b.i4, A_0);
			break;
		case 6:
			this.m_b.k(ref this.m_b.i6, this.m_b.i7, A_0);
			break;
		case 7:
			this.m_b.k(ref this.m_b.i9, this.m_b.ja, A_0);
			break;
		}
		d();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			e = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Up && this.m_d > 0)
		{
			this.m_d--;
			if (this.m_b.io == "Disabled" && this.m_d == 1)
			{
				this.m_d = 0;
			}
			if (this.m_b.ix == "Disabled" && this.m_d == 4)
			{
				this.m_d = 3;
			}
			if (this.m_b.i3 == "Disabled" && this.m_d == 6)
			{
				this.m_d = 5;
			}
			c();
		}
		else if (A_1.KeyCode == Keys.Down && this.m_d < 7)
		{
			this.m_d++;
			if (this.m_b.io == "Disabled" && this.m_d == 1)
			{
				this.m_d = 2;
			}
			if (this.m_b.ix == "Disabled" && this.m_d == 4)
			{
				this.m_d = 5;
			}
			if (this.m_b.i3 == "Disabled" && this.m_d == 6)
			{
				this.m_d = 7;
			}
			c();
		}
		else if (A_1.KeyCode == Keys.Add|| A_1.KeyCode == Keys.Oemplus)
		{
			a(A_0: true);
		}
		else if (A_1.KeyCode == Keys.Subtract|| A_1.KeyCode == Keys.OemMinus)
		{
			a(A_0: false);
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			b();
		}
		else if (A_1.KeyCode == Keys.Prior || A_1.KeyCode == Keys.Home)
		{
			this.m_d = 0;
			c();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			this.m_d = 7;
			c();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			this.m_b.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			this.m_b.na();
			d();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			this.m_b.nd();
			d();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			this.m_b.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = e;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && f != null)
		{
			f.Dispose();
		}
		base.Dispose(disposing);
	}

	private void a()
	{
		g = new PictureBox();
		h = new PictureBox();
		i = new Panel();
		ai = new Label();
		ah = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		aa = new Label();
		ab = new Label();
		ac = new Label();
		ad = new Label();
		ae = new Label();
		af = new Label();
		ag = new Label();
		s = new Label();
		m_t = new Label();
		u = new Label();
		v = new Label();
		w = new Label();
		r = new Label();
		q = new Panel();
		j = new Panel();
		aj = new Label();
		ak = new Label();
		k = new PictureBox();
		l = new Panel();
		m = new Panel();
		n = new Panel();
		o = new Panel();
		p = new Panel();
		((ISupportInitialize)g).BeginInit();
		((ISupportInitialize)h).BeginInit();
		i.SuspendLayout();
		j.SuspendLayout();
		((ISupportInitialize)k).BeginInit();
		SuspendLayout();
		g.Dock = DockStyle.Top;
		g.Image = Resources.ShapkaAll;
		g.Location = new Point(0, 0);
		g.Name = "Shapka";
		g.Size = new Size(1280, 35);
		g.SizeMode = PictureBoxSizeMode.StretchImage;
		g.TabIndex = 0;
		g.TabStop = false;
		h.Dock = DockStyle.Top;
		h.Image = Resources.AdvancedOnly;
		h.Location = new Point(0, 35);
		h.Name = "VerhMenu";
		h.Size = new Size(1280, 35);
		h.SizeMode = PictureBoxSizeMode.StretchImage;
		h.TabIndex = 1;
		h.TabStop = false;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i.AutoScroll = true;
		i.BackColor = Color.FromArgb(190, 190, 190);
		i.Controls.Add(ai);
		i.Controls.Add(ah);
		i.Controls.Add(x);
		i.Controls.Add(y);
		i.Controls.Add(z);
		i.Controls.Add(aa);
		i.Controls.Add(ab);
		i.Controls.Add(ac);
		i.Controls.Add(ad);
		i.Controls.Add(ae);
		i.Controls.Add(af);
		i.Controls.Add(ag);
		i.Controls.Add(s);
		i.Controls.Add(m_t);
		i.Controls.Add(u);
		i.Controls.Add(v);
		i.Controls.Add(w);
		i.Controls.Add(r);
		i.Controls.Add(q);
		i.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		i.ForeColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(12, 92);
		i.Name = "Lev_Panel";
		i.Size = new Size(868, 877);
		i.TabIndex = 2;
		ai.Location = new Point(728, 410);
		ai.Name = "End";
		ai.Size = new Size(126, 37);
		ai.TabIndex = 52;
		ah.Anchor = AnchorStyles.Top;
		ah.AutoSize = true;
		ah.Location = new Point(555, 368);
		ah.Name = "SerialPort1Address_Value";
		ah.Size = new Size(97, 34);
		ah.TabIndex = 51;
		ah.Text = "label1";
		x.AutoSize = true;
		x.Location = new Point(22, 368);
		x.Name = "SerialPort1Address";
		x.Size = new Size(296, 34);
		x.TabIndex = 50;
		x.Text = "Serial Port1 Address";
		y.Anchor = AnchorStyles.Top;
		y.AutoSize = true;
		y.Location = new Point(555, 293);
		y.Name = "ControllerMode_Value";
		y.Size = new Size(97, 34);
		y.TabIndex = 49;
		y.Text = "label1";
		z.AutoSize = true;
		z.Location = new Point(86, 293);
		z.Name = "ControllerMode";
		z.Size = new Size(239, 34);
		z.TabIndex = 48;
		z.Text = "Controller Mode";
		aa.Anchor = AnchorStyles.Top;
		aa.AutoSize = true;
		aa.Location = new Point(555, 259);
		aa.Name = "JMicroneSATAPATAController_Value";
		aa.Size = new Size(97, 34);
		aa.TabIndex = 47;
		aa.Text = "label1";
		ab.AutoSize = true;
		ab.Location = new Point(22, 259);
		ab.Name = "JMicroneSATAPATAController";
		ab.Size = new Size(455, 34);
		ab.TabIndex = 46;
		ab.Text = "J-Micron eSATA/PATA Controller";
		ac.Anchor = AnchorStyles.Top;
		ac.AutoSize = true;
		ac.Location = new Point(555, 225);
		ac.Name = "LANOptionROM_Value";
		ac.Size = new Size(97, 34);
		ac.TabIndex = 45;
		ac.Text = "label1";
		ad.AutoSize = true;
		ad.Location = new Point(86, 225);
		ad.Name = "LANOptionROM";
		ad.Size = new Size(251, 34);
		ad.TabIndex = 44;
		ad.Text = "LAN Option ROM";
		ae.Anchor = AnchorStyles.Top;
		ae.AutoSize = true;
		ae.Location = new Point(555, 191);
		ae.Name = "OnboardPCIEGbeLAN_Value";
		ae.Size = new Size(97, 34);
		ae.TabIndex = 43;
		ae.Text = "label1";
		af.AutoSize = true;
		af.Location = new Point(22, 191);
		af.Name = "OnboardPCIEGbeLAN";
		af.Size = new Size(342, 34);
		af.TabIndex = 42;
		af.Text = "Onboard PCIE Gbe LAN";
		ag.Anchor = AnchorStyles.Top;
		ag.AutoSize = true;
		ag.Location = new Point(555, 157);
		ag.Name = "Onboard1394Controller_Value";
		ag.Size = new Size(97, 34);
		ag.TabIndex = 41;
		ag.Text = "label1";
		s.AutoSize = true;
		s.Location = new Point(22, 157);
		s.Name = "Onboard1394Controller";
		s.Size = new Size(355, 34);
		s.TabIndex = 40;
		s.Text = "Onboard 1394 Controller";
		m_t.Anchor = AnchorStyles.Top;
		m_t.AutoSize = true;
		m_t.Location = new Point(555, 123);
		m_t.Name = "FrontPanelType_Value";
		m_t.Size = new Size(97, 34);
		m_t.TabIndex = 39;
		m_t.Text = "label1";
		u.AutoSize = true;
		u.Location = new Point(86, 123);
		u.Name = "FrontPanelType";
		u.Size = new Size(249, 34);
		u.TabIndex = 38;
		u.Text = "Front Panel Type";
		v.Anchor = AnchorStyles.Top;
		v.AutoSize = true;
		v.Location = new Point(555, 89);
		v.Name = "HighDefinitionAudio_Value";
		v.Size = new Size(97, 34);
		v.TabIndex = 37;
		v.Text = "label1";
		w.AutoSize = true;
		w.Location = new Point(22, 89);
		w.Name = "HighDefinitionAudio";
		w.Size = new Size(311, 34);
		w.TabIndex = 36;
		w.Text = "High Definition Audio";
		r.AutoSize = true;
		r.ForeColor = Color.Black;
		r.Location = new Point(22, 17);
		r.Name = "OnboardDeviceConfiguration_shapka";
		r.Size = new Size(438, 34);
		r.TabIndex = 35;
		r.Text = "Onboard Device Configuration";
		q.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		q.BackColor = Color.FromArgb(27, 35, 165);
		q.Location = new Point(18, 68);
		q.Name = "Goriz_1";
		q.Size = new Size(836, 2);
		q.TabIndex = 1;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.AutoScroll = true;
		j.Controls.Add(aj);
		j.Controls.Add(ak);
		j.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		j.ForeColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(884, 92);
		j.Name = "Prav_Panel";
		j.Size = new Size(382, 877);
		j.TabIndex = 3;
		aj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		aj.Location = new Point(6, 590);
		aj.Name = "Help_Niz";
		aj.Size = new Size(372, 250);
		aj.TabIndex = 1;
		ak.Location = new Point(6, 15);
		ak.Name = "Help_Verh";
		ak.Size = new Size(372, 470);
		ak.TabIndex = 0;
		k.Dock = DockStyle.Bottom;
		k.Image = Resources.NizAll;
		k.Location = new Point(0, 989);
		k.Name = "Niz";
		k.Size = new Size(1280, 35);
		k.SizeMode = PictureBoxSizeMode.StretchImage;
		k.TabIndex = 4;
		k.TabStop = false;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		l.BackColor = Color.FromArgb(27, 35, 165);
		l.Location = new Point(10, 90);
		l.Name = "Goriz1";
		l.Size = new Size(1260, 2);
		l.TabIndex = 0;
		m.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		m.BackColor = Color.FromArgb(27, 35, 165);
		m.Location = new Point(10, 90);
		m.Name = "Vert1";
		m.Size = new Size(4, 879);
		m.TabIndex = 0;
		n.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		n.BackColor = Color.FromArgb(27, 35, 165);
		n.Location = new Point(880, 90);
		n.Name = "Vert2";
		n.Size = new Size(4, 879);
		n.TabIndex = 1;
		o.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		o.BackColor = Color.FromArgb(27, 35, 165);
		o.Location = new Point(10, 969);
		o.Name = "Goriz2";
		o.Size = new Size(1260, 2);
		o.TabIndex = 1;
		p.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		p.BackColor = Color.FromArgb(27, 35, 165);
		p.Location = new Point(1266, 90);
		p.Name = "Vert3";
		p.Size = new Size(4, 879);
		p.TabIndex = 2;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(190, 190, 190);
		base.ClientSize = new Size(1280, 1024);
		base.Controls.Add(o);
		base.Controls.Add(l);
		base.Controls.Add(k);
		base.Controls.Add(h);
		base.Controls.Add(g);
		base.Controls.Add(p);
		base.Controls.Add(n);
		base.Controls.Add(m);
		base.Controls.Add(i);
		base.Controls.Add(j);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Advanced_OnboardDeviceConfiguration_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Advanced_OnboardDeviceConfiguration_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)g).EndInit();
		((ISupportInitialize)h).EndInit();
		i.ResumeLayout(performLayout: false);
		i.PerformLayout();
		j.ResumeLayout(performLayout: false);
		((ISupportInitialize)k).EndInit();
		ResumeLayout(performLayout: false);
	}
}
