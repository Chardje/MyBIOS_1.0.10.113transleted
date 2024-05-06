using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class ab : Form
{
	private const int m_a = 9;

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

	private Label t;

	private Label u;

	private Label v;

	private Label w;

	private Label x;

	private Label y;

	private Label z;

	private Label aa;

	private Label m_ab;

	private Label ac;

	private Label ad;

	private Label ae;

	private Label af;

	private Label ag;

	private Label ah;

	private Label ai;

	private Label aj;

	private Label ak;

	private Label al;

	private Label am;

	private Label an;

	private Label ao;

	public ab(u A_0)
	{
		this.m_b = A_0;
		a();
		d();
		c();
	}

	private void d()
	{
		int num = v.Location.X;
		int num2 = u.Location.X;
		int num3 = 0;
		if (this.m_b.jw == "Disabled")
		{
			num3 = z.Location.Y;
			z.Visible = false;
			ak.Visible = false;
			y.Visible = false;
			aj.Visible = false;
			x.Visible = false;
			ai.Visible = false;
			w.Visible = false;
			ah.Visible = false;
		}
		else
		{
			num3 = z.Location.Y + 136;
			z.Visible = true;
			ak.Visible = true;
			y.Visible = true;
			aj.Visible = true;
			x.Visible = true;
			ai.Visible = true;
			w.Visible = true;
			ah.Visible = true;
		}
		ac.Location = new Point(num, num3);
		ag.Location = new Point(num2, num3);
		m_ab.Location = new Point(num, num3 += 34);
		af.Location = new Point(num2, num3);
		aa.Location = new Point(num, num3 += 34);
		ae.Location = new Point(num2, num3);
		am.Location = new Point(num, num3 += 34);
		ad.Location = new Point(num2, num3);
		u.Text = this.m_b.k(this.m_b.jt);
		al.Text = this.m_b.k(this.m_b.jw);
		ak.Text = this.m_b.k(this.m_b.jz);
		aj.Text = this.m_b.k(this.m_b.j1);
		ai.Text = this.m_b.k(this.m_b.j2);
		ah.Text = this.m_b.k(this.m_b.j3);
		ag.Text = this.m_b.k(this.m_b.j4);
		af.Text = this.m_b.k(this.m_b.j7);
		ae.Text = this.m_b.k(this.m_b.ka);
		ad.Text = this.m_b.k(this.m_b.kd);
		an.Text = this.m_b.o;
	}

	private void c()
	{
		foreach (Control control in i.Controls)
		{
			if (control.Name != "APMConfiguration_shapka")
			{
				control.ForeColor = this.m_b.g;
			}
		}
		switch (this.m_d)
		{
		case 0:
			v.ForeColor = Color.White;
			u.ForeColor = Color.White;
			ao.Text = this.m_b.jv;
			break;
		case 1:
			t.ForeColor = Color.White;
			al.ForeColor = Color.White;
			ao.Text = this.m_b.jy;
			break;
		case 2:
			z.ForeColor = Color.White;
			ak.ForeColor = Color.White;
			ao.Text = "";
			break;
		case 3:
			y.ForeColor = Color.White;
			aj.ForeColor = Color.White;
			ao.Text = "";
			break;
		case 4:
			x.ForeColor = Color.White;
			ai.ForeColor = Color.White;
			ao.Text = "";
			break;
		case 5:
			w.ForeColor = Color.White;
			ah.ForeColor = Color.White;
			ao.Text = "";
			break;
		case 6:
			ac.ForeColor = Color.White;
			ag.ForeColor = Color.White;
			ao.Text = this.m_b.j6;
			break;
		case 7:
			m_ab.ForeColor = Color.White;
			af.ForeColor = Color.White;
			ao.Text = this.m_b.j9;
			break;
		case 8:
			aa.ForeColor = Color.White;
			ae.ForeColor = Color.White;
			ao.Text = this.m_b.kc;
			break;
		case 9:
			am.ForeColor = Color.White;
			ad.ForeColor = Color.White;
			ao.Text = this.m_b.kf;
			break;
		}
	}

	private void b()
	{
		switch (this.m_d)
		{
		case 0:
			this.m_c = new ac(this.m_b, this.m_b.jt, this.m_b.ju);
			this.m_c.ShowDialog();
			this.m_b.jt = this.m_b.m;
			break;
		case 1:
			this.m_c = new ac(this.m_b, this.m_b.jw, this.m_b.jx);
			this.m_c.ShowDialog();
			this.m_b.jw = this.m_b.m;
			break;
		case 6:
			this.m_c = new ac(this.m_b, this.m_b.j4, this.m_b.j5);
			this.m_c.ShowDialog();
			this.m_b.j4 = this.m_b.m;
			break;
		case 7:
			this.m_c = new ac(this.m_b, this.m_b.j7, this.m_b.j8);
			this.m_c.ShowDialog();
			this.m_b.j7 = this.m_b.m;
			break;
		case 8:
			this.m_c = new ac(this.m_b, this.m_b.ka, this.m_b.kb);
			this.m_c.ShowDialog();
			this.m_b.ka = this.m_b.m;
			break;
		case 9:
			this.m_c = new ac(this.m_b, this.m_b.kd, this.m_b.ke);
			this.m_c.ShowDialog();
			this.m_b.kd = this.m_b.m;
			break;
		}
		d();
	}

	private void a(bool A_0)
	{
		switch (this.m_d)
		{
		case 0:
			this.m_b.k(ref this.m_b.jt, this.m_b.ju, A_0);
			break;
		case 1:
			this.m_b.k(ref this.m_b.jw, this.m_b.jx, A_0);
			break;
		case 2:
			this.m_b.k(ref this.m_b.jz, this.m_b.j0, A_0);
			break;
		case 3:
			this.m_b.k(ref this.m_b.j1, this.m_b.um, A_0);
			break;
		case 4:
			this.m_b.k(ref this.m_b.j2, this.m_b.v, A_0);
			break;
		case 5:
			this.m_b.k(ref this.m_b.j3, this.m_b.w, A_0);
			break;
		case 6:
			this.m_b.k(ref this.m_b.j4, this.m_b.j5, A_0);
			break;
		case 7:
			this.m_b.k(ref this.m_b.j7, this.m_b.j8, A_0);
			break;
		case 8:
			this.m_b.k(ref this.m_b.ka, this.m_b.kb, A_0);
			break;
		case 9:
			this.m_b.k(ref this.m_b.kd, this.m_b.ke, A_0);
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
			if (this.m_b.jw == "Disabled" && (this.m_d == 2 || this.m_d == 3 || this.m_d == 4 || this.m_d == 5))
			{
				this.m_d = 1;
			}
			c();
		}
		else if (A_1.KeyCode == Keys.Down && this.m_d < 9)
		{
			this.m_d++;
			if (this.m_b.jw == "Disabled" && (this.m_d == 2 || this.m_d == 3 || this.m_d == 4 || this.m_d == 5))
			{
				this.m_d = 6;
			}
			c();
		}
		else if (A_1.KeyCode == Keys.Add || A_1.KeyCode == Keys.Oemplus)
		{
			a(A_0: true);
		}
		else if (A_1.KeyCode == Keys.Subtract || A_1.KeyCode == Keys.OemMinus)
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
			this.m_d = 9;
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
		ad = new Label();
		ae = new Label();
		af = new Label();
		ag = new Label();
		ah = new Label();
		ai = new Label();
		aj = new Label();
		ak = new Label();
		al = new Label();
		am = new Label();
		aa = new Label();
		m_ab = new Label();
		ac = new Label();
		w = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		t = new Label();
		u = new Label();
		v = new Label();
		s = new Label();
		r = new Label();
		q = new Panel();
		j = new Panel();
		an = new Label();
		ao = new Label();
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
		h.Image = Resources.PowerOnly;
		h.Location = new Point(0, 35);
		h.Name = "VerhMenu";
		h.Size = new Size(1280, 35);
		h.SizeMode = PictureBoxSizeMode.StretchImage;
		h.TabIndex = 1;
		h.TabStop = false;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i.AutoScroll = true;
		i.BackColor = Color.FromArgb(190, 190, 190);
		i.Controls.Add(ad);
		i.Controls.Add(ae);
		i.Controls.Add(af);
		i.Controls.Add(ag);
		i.Controls.Add(ah);
		i.Controls.Add(ai);
		i.Controls.Add(aj);
		i.Controls.Add(ak);
		i.Controls.Add(al);
		i.Controls.Add(am);
		i.Controls.Add(aa);
		i.Controls.Add(m_ab);
		i.Controls.Add(ac);
		i.Controls.Add(w);
		i.Controls.Add(x);
		i.Controls.Add(y);
		i.Controls.Add(z);
		i.Controls.Add(t);
		i.Controls.Add(u);
		i.Controls.Add(v);
		i.Controls.Add(s);
		i.Controls.Add(r);
		i.Controls.Add(q);
		i.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		i.ForeColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(12, 92);
		i.Name = "Lev_Panel";
		i.Size = new Size(868, 877);
		i.TabIndex = 2;
		ad.Anchor = AnchorStyles.Top;
		ad.AutoSize = true;
		ad.Location = new Point(524, 389);
		ad.Name = "PowerOnByPS2Keyboard_Value";
		ad.Size = new Size(97, 34);
		ad.TabIndex = 64;
		ad.Text = "label9";
		ae.Anchor = AnchorStyles.Top;
		ae.AutoSize = true;
		ae.Location = new Point(524, 355);
		ae.Name = "PowerOnByPCIEDevices_Value";
		ae.Size = new Size(97, 34);
		ae.TabIndex = 63;
		ae.Text = "label8";
		af.Anchor = AnchorStyles.Top;
		af.AutoSize = true;
		af.Location = new Point(524, 321);
		af.Name = "PowerOnByPCIDevices_Value";
		af.Size = new Size(97, 34);
		af.TabIndex = 62;
		af.Text = "label7";
		ag.Anchor = AnchorStyles.Top;
		ag.AutoSize = true;
		ag.Location = new Point(524, 287);
		ag.Name = "PowerOnByExternalModems_Value";
		ag.Size = new Size(97, 34);
		ag.TabIndex = 61;
		ag.Text = "label6";
		ah.Anchor = AnchorStyles.Top;
		ah.AutoSize = true;
		ah.Location = new Point(524, 253);
		ah.Name = "RTCAlarmSecond_Value";
		ah.Size = new Size(97, 34);
		ah.TabIndex = 60;
		ah.Text = "label5";
		ai.Anchor = AnchorStyles.Top;
		ai.AutoSize = true;
		ai.Location = new Point(524, 219);
		ai.Name = "RTCAlarmMinute_Value";
		ai.Size = new Size(97, 34);
		ai.TabIndex = 59;
		ai.Text = "label4";
		aj.Anchor = AnchorStyles.Top;
		aj.AutoSize = true;
		aj.Location = new Point(524, 185);
		aj.Name = "RTCAlarmHour_Value";
		aj.Size = new Size(97, 34);
		aj.TabIndex = 58;
		aj.Text = "label3";
		ak.Anchor = AnchorStyles.Top;
		ak.AutoSize = true;
		ak.Location = new Point(524, 151);
		ak.Name = "RTCAlarmDate_Value";
		ak.Size = new Size(97, 34);
		ak.TabIndex = 57;
		ak.Text = "label2";
		al.Anchor = AnchorStyles.Top;
		al.AutoSize = true;
		al.Location = new Point(524, 117);
		al.Name = "PowerOnByRTCAlarm_Value";
		al.Size = new Size(97, 34);
		al.TabIndex = 56;
		al.Text = "label1";
		am.AutoSize = true;
		am.Location = new Point(22, 389);
		am.Name = "PowerOnByPS2Keyboard";
		am.Size = new Size(406, 34);
		am.TabIndex = 55;
		am.Text = "Power On By PS/2 Keyboard";
		aa.AutoSize = true;
		aa.Location = new Point(22, 355);
		aa.Name = "PowerOnByPCIEDevices";
		aa.Size = new Size(387, 34);
		aa.TabIndex = 54;
		aa.Text = "Power On By PCIE Devices";
		m_ab.AutoSize = true;
		m_ab.Location = new Point(22, 321);
		m_ab.Name = "PowerOnByPCIDevices";
		m_ab.Size = new Size(368, 34);
		m_ab.TabIndex = 53;
		m_ab.Text = "Power On By PCI Devices";
		ac.AutoSize = true;
		ac.Location = new Point(22, 287);
		ac.Name = "PowerOnByExternalModems";
		ac.Size = new Size(443, 34);
		ac.TabIndex = 52;
		ac.Text = "Power On By External Modems";
		w.AutoSize = true;
		w.Location = new Point(54, 253);
		w.Name = "RTCAlarmSecond";
		w.Size = new Size(275, 34);
		w.TabIndex = 51;
		w.Text = "RTC Alarm Second";
		x.AutoSize = true;
		x.Location = new Point(54, 219);
		x.Name = "RTCAlarmMinute";
		x.Size = new Size(265, 34);
		x.TabIndex = 50;
		x.Text = "RTC Alarm Minute";
		y.AutoSize = true;
		y.Location = new Point(54, 185);
		y.Name = "RTCAlarmHour";
		y.Size = new Size(238, 34);
		y.TabIndex = 49;
		y.Text = "RTC Alarm Hour";
		z.AutoSize = true;
		z.Location = new Point(54, 151);
		z.Name = "RTCAlarmDate";
		z.Size = new Size(233, 34);
		z.TabIndex = 48;
		z.Text = "RTC Alarm Date";
		t.AutoSize = true;
		t.Location = new Point(22, 117);
		t.Name = "PowerOnByRTCAlarm";
		t.Size = new Size(349, 34);
		t.TabIndex = 47;
		t.Text = "Power On By RTC Alarm";
		u.Anchor = AnchorStyles.Top;
		u.AutoSize = true;
		u.Location = new Point(524, 83);
		u.Name = "RestoreonACPowerLoss_Value";
		u.Size = new Size(97, 34);
		u.TabIndex = 46;
		u.Text = "label1";
		v.AutoSize = true;
		v.Location = new Point(22, 83);
		v.Name = "RestoreonACPowerLoss";
		v.Size = new Size(385, 34);
		v.TabIndex = 45;
		v.Text = "Restore on AC Power Loss";
		s.Location = new Point(700, 17);
		s.Name = "End";
		s.Size = new Size(126, 37);
		s.TabIndex = 44;
		r.AutoSize = true;
		r.ForeColor = Color.Black;
		r.Location = new Point(22, 17);
		r.Name = "APMConfiguration_shapka";
		r.Size = new Size(278, 34);
		r.TabIndex = 35;
		r.Text = "APM Configuration";
		q.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		q.BackColor = Color.FromArgb(27, 35, 165);
		q.Location = new Point(18, 68);
		q.Name = "Goriz_1";
		q.Size = new Size(828, 2);
		q.TabIndex = 1;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.AutoScroll = true;
		j.Controls.Add(an);
		j.Controls.Add(ao);
		j.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		j.ForeColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(884, 92);
		j.Name = "Prav_Panel";
		j.Size = new Size(382, 877);
		j.TabIndex = 3;
		an.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		an.Location = new Point(6, 590);
		an.Name = "Help_Niz";
		an.Size = new Size(372, 250);
		an.TabIndex = 1;
		ao.Location = new Point(6, 15);
		ao.Name = "Help_Verh";
		ao.Size = new Size(372, 470);
		ao.TabIndex = 0;
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
		base.Name = "Power_APMConfiguration_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Power_APMConfiguration_Form";
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
