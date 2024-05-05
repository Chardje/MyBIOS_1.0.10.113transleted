using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class b : Form
{
	private const int m_a = 14;

	private IContainer m_b;

	private PictureBox m_c;

	private PictureBox m_d;

	private Panel m_e;

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

	private Label ap;

	private Label aq;

	private Label ar;

	private Label @as;

	private Label at;

	private Label au;

	private u av;

	private ac aw;

	private int ax;

	private bool ay = true;

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.m_b != null)
		{
			this.m_b.Dispose();
		}
		base.Dispose(disposing);
	}

	private void e()
	{
		this.m_c = new PictureBox();
		this.m_d = new PictureBox();
		this.m_e = new Panel();
		ar = new Label();
		@as = new Label();
		ao = new Label();
		ap = new Label();
		aq = new Label();
		ae = new Label();
		af = new Label();
		ag = new Label();
		ah = new Label();
		ai = new Label();
		aj = new Label();
		ak = new Label();
		al = new Label();
		am = new Label();
		an = new Label();
		ad = new Label();
		u = new Label();
		v = new Label();
		w = new Label();
		x = new Label();
		y = new Label();
		z = new Label();
		aa = new Label();
		ab = new Label();
		ac = new Label();
		p = new Label();
		q = new Label();
		r = new Label();
		s = new Label();
		t = new Label();
		o = new Label();
		n = new Label();
		m = new Panel();
		f = new Panel();
		at = new Label();
		au = new Label();
		g = new PictureBox();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		((ISupportInitialize)this.m_c).BeginInit();
		((ISupportInitialize)this.m_d).BeginInit();
		this.m_e.SuspendLayout();
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
		this.m_d.Image = Resources.PowerOnly;
		this.m_d.Location = new Point(0, 35);
		this.m_d.Name = "VerhMenu";
		this.m_d.Size = new Size(1280, 35);
		this.m_d.SizeMode = PictureBoxSizeMode.StretchImage;
		this.m_d.TabIndex = 1;
		this.m_d.TabStop = false;
		this.m_e.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		this.m_e.AutoScroll = true;
		this.m_e.BackColor = Color.FromArgb(190, 190, 190);
		this.m_e.Controls.Add(ar);
		this.m_e.Controls.Add(@as);
		this.m_e.Controls.Add(ao);
		this.m_e.Controls.Add(ap);
		this.m_e.Controls.Add(aq);
		this.m_e.Controls.Add(ae);
		this.m_e.Controls.Add(af);
		this.m_e.Controls.Add(ag);
		this.m_e.Controls.Add(ah);
		this.m_e.Controls.Add(ai);
		this.m_e.Controls.Add(aj);
		this.m_e.Controls.Add(ak);
		this.m_e.Controls.Add(al);
		this.m_e.Controls.Add(am);
		this.m_e.Controls.Add(an);
		this.m_e.Controls.Add(ad);
		this.m_e.Controls.Add(u);
		this.m_e.Controls.Add(v);
		this.m_e.Controls.Add(w);
		this.m_e.Controls.Add(x);
		this.m_e.Controls.Add(y);
		this.m_e.Controls.Add(z);
		this.m_e.Controls.Add(aa);
		this.m_e.Controls.Add(ab);
		this.m_e.Controls.Add(ac);
		this.m_e.Controls.Add(p);
		this.m_e.Controls.Add(q);
		this.m_e.Controls.Add(r);
		this.m_e.Controls.Add(s);
		this.m_e.Controls.Add(t);
		this.m_e.Controls.Add(o);
		this.m_e.Controls.Add(n);
		this.m_e.Controls.Add(m);
		this.m_e.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		this.m_e.ForeColor = Color.FromArgb(27, 35, 165);
		this.m_e.Location = new Point(12, 92);
		this.m_e.Name = "Lev_Panel";
		this.m_e.Size = new Size(868, 877);
		this.m_e.TabIndex = 2;
		ar.Anchor = AnchorStyles.Top;
		ar.AutoSize = true;
		ar.Location = new Point(497, 608);
		ar.Name = "V12Voltage_Value";
		ar.Size = new Size(97, 34);
		ar.TabIndex = 74;
		ar.Text = "label1";
		@as.AutoSize = true;
		@as.Location = new Point(22, 608);
		@as.Name = "V12Voltage";
		@as.Size = new Size(177, 34);
		@as.TabIndex = 73;
		@as.Text = "12V Voltage";
		ao.Anchor = AnchorStyles.Top;
		ao.AutoSize = true;
		ao.Location = new Point(497, 574);
		ao.Name = "V5Voltage_Value";
		ao.Size = new Size(97, 34);
		ao.TabIndex = 72;
		ao.Text = "label1";
		ap.AutoSize = true;
		ap.Location = new Point(22, 574);
		ap.Name = "V5Voltage";
		ap.Size = new Size(161, 34);
		ap.TabIndex = 71;
		ap.Text = "5V Voltage";
		aq.Anchor = AnchorStyles.Top;
		aq.AutoSize = true;
		aq.Location = new Point(497, 540);
		aq.Name = "V33Voltage_Value";
		aq.Size = new Size(97, 34);
		aq.TabIndex = 70;
		aq.Text = "label1";
		ae.AutoSize = true;
		ae.Location = new Point(22, 540);
		ae.Name = "V33Voltage";
		ae.Size = new Size(185, 34);
		ae.TabIndex = 69;
		ae.Text = "3.3V Voltage";
		af.Anchor = AnchorStyles.Top;
		af.AutoSize = true;
		af.Location = new Point(497, 506);
		af.Name = "VCOREVoltage_Value";
		af.Size = new Size(97, 34);
		af.TabIndex = 68;
		af.Text = "label1";
		ag.AutoSize = true;
		ag.Location = new Point(22, 506);
		ag.Name = "VCOREVoltage";
		ag.Size = new Size(228, 34);
		ag.TabIndex = 67;
		ag.Text = "VCORE Voltage";
		ah.Anchor = AnchorStyles.Top;
		ah.AutoSize = true;
		ah.Location = new Point(497, 446);
		ah.Name = "PowerFanSpeed_Value";
		ah.Size = new Size(97, 34);
		ah.TabIndex = 66;
		ah.Text = "label1";
		ai.AutoSize = true;
		ai.Location = new Point(22, 446);
		ai.Name = "PowerFanSpeed";
		ai.Size = new Size(257, 34);
		ai.TabIndex = 65;
		ai.Text = "Power Fan Speed";
		aj.Anchor = AnchorStyles.Top;
		aj.AutoSize = true;
		aj.Location = new Point(497, 412);
		aj.Name = "ChassisTargetTemperature_Value";
		aj.Size = new Size(97, 34);
		aj.TabIndex = 64;
		aj.Text = "label1";
		ak.AutoSize = true;
		ak.Location = new Point(22, 412);
		ak.Name = "ChassisTargetTemperature";
		ak.Size = new Size(403, 34);
		ak.TabIndex = 63;
		ak.Text = "Chassis Target Temperature";
		al.Anchor = AnchorStyles.Top;
		al.AutoSize = true;
		al.Location = new Point(497, 378);
		al.Name = "ChassisFanRatio_Value";
		al.Size = new Size(97, 34);
		al.TabIndex = 62;
		al.Text = "label1";
		am.AutoSize = true;
		am.Location = new Point(22, 378);
		am.Name = "ChassisFanRatio";
		am.Size = new Size(267, 34);
		am.TabIndex = 61;
		am.Text = "Chassis Fan Ratio";
		an.Anchor = AnchorStyles.Top;
		an.AutoSize = true;
		an.Location = new Point(497, 344);
		an.Name = "ChassisQFanControl_Value";
		an.Size = new Size(97, 34);
		an.TabIndex = 60;
		an.Text = "label1";
		ad.AutoSize = true;
		ad.Location = new Point(22, 344);
		ad.Name = "ChassisQFanControl";
		ad.Size = new Size(330, 34);
		ad.TabIndex = 59;
		ad.Text = "Chassis Q-Fan Control";
		u.Anchor = AnchorStyles.Top;
		u.AutoSize = true;
		u.Location = new Point(497, 310);
		u.Name = "ChassisFan2Speed_Value";
		u.Size = new Size(97, 34);
		u.TabIndex = 58;
		u.Text = "label1";
		v.AutoSize = true;
		v.Location = new Point(22, 310);
		v.Name = "ChassisFan2Speed";
		v.Size = new Size(305, 34);
		v.TabIndex = 57;
		v.Text = "Chassis Fan 2 Speed";
		w.Anchor = AnchorStyles.Top;
		w.AutoSize = true;
		w.Location = new Point(497, 276);
		w.Name = "ChassisFan1Speed_Value";
		w.Size = new Size(97, 34);
		w.TabIndex = 56;
		w.Text = "label1";
		x.AutoSize = true;
		x.Location = new Point(22, 276);
		x.Name = "ChassisFan1Speed";
		x.Size = new Size(305, 34);
		x.TabIndex = 55;
		x.Text = "Chassis Fan 1 Speed";
		y.Anchor = AnchorStyles.Top;
		y.AutoSize = true;
		y.Location = new Point(497, 242);
		y.Name = "CPUFanProfile_Value";
		y.Size = new Size(97, 34);
		y.TabIndex = 54;
		y.Text = "label1";
		z.AutoSize = true;
		z.Location = new Point(22, 242);
		z.Name = "CPUFanProfile";
		z.Size = new Size(234, 34);
		z.TabIndex = 53;
		z.Text = "CPU Fan Profile";
		aa.Anchor = AnchorStyles.Top;
		aa.AutoSize = true;
		aa.Location = new Point(497, 208);
		aa.Name = "CPUQFanControl_Value";
		aa.Size = new Size(97, 34);
		aa.TabIndex = 52;
		aa.Text = "label1";
		ab.AutoSize = true;
		ab.Location = new Point(22, 208);
		ab.Name = "CPUQFanControl";
		ab.Size = new Size(280, 34);
		ab.TabIndex = 51;
		ab.Text = "CPU Q-Fan Control";
		ac.Anchor = AnchorStyles.Top;
		ac.AutoSize = true;
		ac.Location = new Point(497, 174);
		ac.Name = "CPUFanSpeed_Value";
		ac.Size = new Size(97, 34);
		ac.TabIndex = 50;
		ac.Text = "label1";
		p.AutoSize = true;
		p.Location = new Point(22, 174);
		p.Name = "CPUFanSpeed";
		p.Size = new Size(231, 34);
		p.TabIndex = 49;
		p.Text = "CPU Fan Speed";
		q.Anchor = AnchorStyles.Top;
		q.AutoSize = true;
		q.Location = new Point(497, 117);
		q.Name = "MBTemperature_Value";
		q.Size = new Size(97, 34);
		q.TabIndex = 48;
		q.Text = "label1";
		r.AutoSize = true;
		r.Location = new Point(22, 117);
		r.Name = "MBTemperature";
		r.Size = new Size(242, 34);
		r.TabIndex = 47;
		r.Text = "MB Temperature";
		s.Anchor = AnchorStyles.Top;
		s.AutoSize = true;
		s.Location = new Point(497, 83);
		s.Name = "CPUTemperature_Value";
		s.Size = new Size(97, 34);
		s.TabIndex = 46;
		s.Text = "label1";
		t.AutoSize = true;
		t.Location = new Point(22, 83);
		t.Name = "CPUTemperature";
		t.Size = new Size(258, 34);
		t.TabIndex = 45;
		t.Text = "CPU Temperature";
		o.Location = new Point(700, 17);
		o.Name = "End";
		o.Size = new Size(126, 37);
		o.TabIndex = 44;
		n.AutoSize = true;
		n.ForeColor = Color.Black;
		n.Location = new Point(22, 17);
		n.Name = "HardwareMonitor_shapka";
		n.Size = new Size(263, 34);
		n.TabIndex = 35;
		n.Text = "Hardware Monitor";
		m.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		m.BackColor = Color.FromArgb(27, 35, 165);
		m.Location = new Point(18, 68);
		m.Name = "Goriz_1";
		m.Size = new Size(828, 2);
		m.TabIndex = 1;
		f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		f.AutoScroll = true;
		f.Controls.Add(at);
		f.Controls.Add(au);
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(884, 92);
		f.Name = "Prav_Panel";
		f.Size = new Size(382, 877);
		f.TabIndex = 3;
		at.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		at.Location = new Point(6, 590);
		at.Name = "Help_Niz";
		at.Size = new Size(372, 250);
		at.TabIndex = 1;
		au.Location = new Point(6, 15);
		au.Name = "Help_Verh";
		au.Size = new Size(372, 470);
		au.TabIndex = 0;
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
		base.Controls.Add(this.m_e);
		base.Controls.Add(f);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "Power_HardwareMonitor_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Power_HardwareMonitor_Form";
		base.WindowState = FormWindowState.Maximized;
		base.FormClosing += a;
		base.KeyDown += a;
		((ISupportInitialize)this.m_c).EndInit();
		((ISupportInitialize)this.m_d).EndInit();
		this.m_e.ResumeLayout(performLayout: false);
		this.m_e.PerformLayout();
		f.ResumeLayout(performLayout: false);
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
	}

	public b(u A_0)
	{
		av = A_0;
		e();
		d();
		bm();
	}

	private void d()
	{
		this.m_e.AutoScroll = false;
		int num = t.Location.X;
		int num2 = s.Location.X;
		int num3 = 0;
		if (av.kq == "Disabled")
		{
			num3 = z.Location.Y;
			z.Visible = false;
			y.Visible = false;
		}
		else
		{
			num3 = z.Location.Y + 34;
			z.Visible = true;
			y.Visible = true;
		}
		x.Location = new Point(num, num3);
		w.Location = new Point(num2, num3);
		v.Location = new Point(num, num3 += 34);
		u.Location = new Point(num2, num3);
		ad.Location = new Point(num, num3 += 34);
		an.Location = new Point(num2, num3);
		am.Location = new Point(num, num3 += 34);
		al.Location = new Point(num2, num3);
		ak.Location = new Point(num, num3 += 34);
		aj.Location = new Point(num2, num3);
		if (av.k2 == "Disabled")
		{
			num3 = am.Location.Y;
			am.Visible = false;
			al.Visible = false;
			ak.Visible = false;
			aj.Visible = false;
		}
		else
		{
			num3 = am.Location.Y + 68;
			am.Visible = true;
			al.Visible = true;
			ak.Visible = true;
			aj.Visible = true;
		}
		ai.Location = new Point(num, num3);
		ah.Location = new Point(num2, num3);
		ag.Location = new Point(num, num3 += 68);
		af.Location = new Point(num2, num3);
		ae.Location = new Point(num, num3 += 34);
		aq.Location = new Point(num2, num3);
		ap.Location = new Point(num, num3 += 34);
		ao.Location = new Point(num2, num3);
		@as.Location = new Point(num, num3 += 34);
		ar.Location = new Point(num2, num3);
		s.Text = av.k(av.kh);
		q.Text = av.k(av.kk);
		ac.Text = av.k(av.kn);
		aa.Text = av.k(av.kq);
		y.Text = av.k(av.kt);
		w.Text = av.k(av.kw);
		u.Text = av.k(av.kz);
		an.Text = av.k(av.k2);
		al.Text = av.k(av.k5);
		aj.Text = av.k(av.k8);
		ah.Text = av.k(av.lb);
		af.Text = av.k(av.le);
		aq.Text = av.k(av.lh);
		ao.Text = av.k(av.lk);
		ar.Text = av.k(av.ln);
		at.Text = av.o;
		this.m_e.AutoScroll = true;
		c();
	}

	private void c()
	{
		if (ax < 7)
		{
			this.m_e.ScrollControlIntoView(n);
		}
		else
		{
			this.m_e.ScrollControlIntoView(@as);
		}
	}

	private void bm()
	{
		foreach (Control control in this.m_e.Controls)
		{
			if (control.Name != "HardwareMonitor_shapka")
			{
				control.ForeColor = av.g;
			}
		}
		switch (ax)
		{
		case 0:
			t.ForeColor = Color.White;
			s.ForeColor = Color.White;
			au.Text = av.kj;
			break;
		case 1:
			r.ForeColor = Color.White;
			q.ForeColor = Color.White;
			au.Text = av.km;
			break;
		case 2:
			p.ForeColor = Color.White;
			ac.ForeColor = Color.White;
			au.Text = av.kp;
			break;
		case 3:
			ab.ForeColor = Color.White;
			aa.ForeColor = Color.White;
			au.Text = av.ks;
			break;
		case 4:
			z.ForeColor = Color.White;
			y.ForeColor = Color.White;
			au.Text = av.kv;
			break;
		case 5:
			x.ForeColor = Color.White;
			w.ForeColor = Color.White;
			au.Text = av.ky;
			break;
		case 6:
			v.ForeColor = Color.White;
			u.ForeColor = Color.White;
			au.Text = av.k1;
			break;
		case 7:
			ad.ForeColor = Color.White;
			an.ForeColor = Color.White;
			au.Text = av.k4;
			break;
		case 8:
			am.ForeColor = Color.White;
			al.ForeColor = Color.White;
			au.Text = av.k7;
			break;
		case 9:
			ak.ForeColor = Color.White;
			aj.ForeColor = Color.White;
			au.Text = av.la;
			break;
		case 10:
			ai.ForeColor = Color.White;
			ah.ForeColor = Color.White;
			au.Text = av.ld;
			break;
		case 11:
			ag.ForeColor = Color.White;
			af.ForeColor = Color.White;
			au.Text = av.lg;
			break;
		case 12:
			ae.ForeColor = Color.White;
			aq.ForeColor = Color.White;
			au.Text = av.lj;
			break;
		case 13:
			ap.ForeColor = Color.White;
			ao.ForeColor = Color.White;
			au.Text = av.lm;
			break;
		case 14:
			@as.ForeColor = Color.White;
			ar.ForeColor = Color.White;
			au.Text = av.lp;
			break;
		}
		c();
	}

	private void a()
	{
		switch (ax)
		{
		case 0:
			aw = new ac(av, av.kh, av.ki);
			aw.ShowDialog();
			av.kh = av.m;
			break;
		case 1:
			aw = new ac(av, av.kk, av.kl);
			aw.ShowDialog();
			av.kk = av.m;
			break;
		case 2:
			aw = new ac(av, av.kn, av.ko);
			aw.ShowDialog();
			av.kn = av.m;
			break;
		case 3:
			aw = new ac(av, av.kq, av.kr);
			aw.ShowDialog();
			av.kq = av.m;
			break;
		case 4:
			aw = new ac(av, av.kt, av.ku);
			aw.ShowDialog();
			av.kt = av.m;
			break;
		case 5:
			aw = new ac(av, av.kw, av.kx);
			aw.ShowDialog();
			av.kw = av.m;
			break;
		case 6:
			aw = new ac(av, av.kz, av.k0);
			aw.ShowDialog();
			av.kz = av.m;
			break;
		case 7:
			aw = new ac(av, av.k2, av.k3);
			aw.ShowDialog();
			av.k2 = av.m;
			break;
		case 8:
			aw = new ac(av, av.k5, av.k6);
			aw.ShowDialog();
			av.k5 = av.m;
			break;
		case 9:
			aw = new ac(av, av.k8, av.k9);
			aw.ShowDialog();
			av.k8 = av.m;
			break;
		case 10:
			aw = new ac(av, av.lb, av.lc);
			aw.ShowDialog();
			av.lb = av.m;
			break;
		case 11:
			aw = new ac(av, av.le, av.lf);
			aw.ShowDialog();
			av.le = av.m;
			break;
		case 12:
			aw = new ac(av, av.lh, av.li);
			aw.ShowDialog();
			av.lh = av.m;
			break;
		case 13:
			aw = new ac(av, av.lk, av.ll);
			aw.ShowDialog();
			av.lk = av.m;
			break;
		case 14:
			aw = new ac(av, av.ln, av.lo);
			aw.ShowDialog();
			av.ln = av.m;
			break;
		}
		d();
	}

	private void a(bool A_0)
	{
		switch (ax)
		{
		case 0:
			av.k(ref av.kh, av.ki, A_0);
			break;
		case 1:
			av.k(ref av.kk, av.kl, A_0);
			break;
		case 2:
			av.k(ref av.kn, av.ko, A_0);
			break;
		case 3:
			av.k(ref av.kq, av.kr, A_0);
			break;
		case 4:
			av.k(ref av.kt, av.ku, A_0);
			break;
		case 5:
			av.k(ref av.kw, av.kx, A_0);
			break;
		case 6:
			av.k(ref av.kz, av.k0, A_0);
			break;
		case 7:
			av.k(ref av.k2, av.k3, A_0);
			break;
		case 8:
			av.k(ref av.k5, av.k6, A_0);
			break;
		case 9:
			av.k(ref av.k8, av.k9, A_0);
			break;
		case 10:
			av.k(ref av.lb, av.lc, A_0);
			break;
		case 11:
			av.k(ref av.le, av.lf, A_0);
			break;
		case 12:
			av.k(ref av.lh, av.li, A_0);
			break;
		case 13:
			av.k(ref av.lk, av.ll, A_0);
			break;
		case 14:
			av.k(ref av.ln, av.lo, A_0);
			break;
		}
		d();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			ay = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Up && ax > 0)
		{
			ax--;
			if (av.kq == "Disabled" && ax == 4)
			{
				ax = 3;
			}
			if (av.k2 == "Disabled" && (ax == 8 || ax == 9))
			{
				ax = 7;
			}
			bm();
		}
		else if (A_1.KeyCode == Keys.Down && ax < 14)
		{
			ax++;
			if (av.kq == "Disabled" && ax == 4)
			{
				ax = 5;
			}
			if (av.k2 == "Disabled" && (ax == 8 || ax == 9))
			{
				ax = 10;
			}
			bm();
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
			ax = 0;
			bm();
		}
		else if (A_1.KeyCode == Keys.Next || A_1.KeyCode == Keys.End)
		{
			ax = 14;
			bm();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			av.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			av.na();
			d();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			av.nd();
			d();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			av.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = ay;
	}
}
