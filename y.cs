using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MyBIOS.Properties;

public class y : Form
{
	private const int m_a = 5;

	private u m_b;

	private ac m_c;

	private int m_d;

	private bool m_e = true;

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

	private Panel r;

	private Label s;

	private Label t;

	private Label u;

	private Label v;

	private Label w;

	private Label x;

	private Label m_y;

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

	private Label av;

	private Label aw;

	private Label ax;

	private Label ay;

	private Label az;

	public y(u A_0)
	{
		this.m_b = A_0;
		a();
		e();
		c();
	}

	private void e()
	{
		if (this.m_b.eg != "Auto")
		{
			ao.Visible = false;
			aw.Visible = false;
		}
		else
		{
			ao.Visible = true;
			aw.Visible = true;
		}
		ac.Text = ":" + this.m_b.hl;
		ak.Text = ":" + this.m_b.hm;
		aj.Text = ":" + this.m_b.hn;
		ai.Text = ":" + this.m_b.ho;
		ah.Text = ":" + this.m_b.hp;
		ag.Text = ":" + this.m_b.hq;
		af.Text = ":" + this.m_b.hr;
		ae.Text = ":" + this.m_b.hs;
		ad.Text = ":" + this.m_b.ht;
		am.Text = this.m_b.k(this.m_b.eg);
		av.Text = this.m_b.k(this.m_b.hu);
		ar.Text = this.m_b.k(this.m_b.hx);
		aq.Text = this.m_b.k(this.m_b.h0);
		ap.Text = this.m_b.k(this.m_b.h3);
		aw.Text = this.m_b.k(this.m_b.h6);
		d();
	}

	private void d()
	{
		if (this.m_d < 3)
		{
			i.ScrollControlIntoView(s);
		}
		else
		{
			i.ScrollControlIntoView(ao);
		}
	}

	private void c()
	{
		if (this.m_b.eg != "Auto" && this.m_d == 5)
		{
			this.m_d = 4;
		}
		an.ForeColor = this.m_b.g;
		am.ForeColor = this.m_b.g;
		al.ForeColor = this.m_b.g;
		av.ForeColor = this.m_b.g;
		au.ForeColor = this.m_b.g;
		ar.ForeColor = this.m_b.g;
		at.ForeColor = this.m_b.g;
		aq.ForeColor = this.m_b.g;
		@as.ForeColor = this.m_b.g;
		ap.ForeColor = this.m_b.g;
		ao.ForeColor = this.m_b.g;
		aw.ForeColor = this.m_b.g;
		switch (this.m_d)
		{
		case 0:
			az.Text = this.m_b.ei;
			ay.Text = this.m_b.q;
			an.ForeColor = Color.White;
			am.ForeColor = Color.White;
			break;
		case 1:
			az.Text = this.m_b.hw;
			ay.Text = this.m_b.o;
			al.ForeColor = Color.White;
			av.ForeColor = Color.White;
			break;
		case 2:
			az.Text = this.m_b.hz;
			ay.Text = this.m_b.o;
			au.ForeColor = Color.White;
			ar.ForeColor = Color.White;
			break;
		case 3:
			az.Text = this.m_b.h2;
			ay.Text = this.m_b.o;
			at.ForeColor = Color.White;
			aq.ForeColor = Color.White;
			break;
		case 4:
			az.Text = this.m_b.h5;
			ay.Text = this.m_b.o;
			@as.ForeColor = Color.White;
			ap.ForeColor = Color.White;
			break;
		case 5:
			az.Text = this.m_b.h8;
			ay.Text = this.m_b.o;
			ao.ForeColor = Color.White;
			aw.ForeColor = Color.White;
			break;
		}
		d();
	}

	private void b()
	{
		switch (this.m_d)
		{
		case 1:
			this.m_c = new ac(this.m_b, this.m_b.hu, this.m_b.hv);
			this.m_c.ShowDialog();
			this.m_b.hu = this.m_b.m;
			break;
		case 2:
			this.m_c = new ac(this.m_b, this.m_b.hx, this.m_b.hy);
			this.m_c.ShowDialog();
			this.m_b.hx = this.m_b.m;
			break;
		case 3:
			this.m_c = new ac(this.m_b, this.m_b.h0, this.m_b.h1);
			this.m_c.ShowDialog();
			this.m_b.h0 = this.m_b.m;
			break;
		case 4:
			this.m_c = new ac(this.m_b, this.m_b.h3, this.m_b.h4);
			this.m_c.ShowDialog();
			this.m_b.h3 = this.m_b.m;
			break;
		case 5:
			this.m_c = new ac(this.m_b, this.m_b.h6, this.m_b.h7);
			this.m_c.ShowDialog();
			this.m_b.h6 = this.m_b.m;
			break;
		}
		e();
	}

	private void a(bool A_0)
	{
		switch (this.m_d)
		{
		case 0:
			this.m_b.k(ref this.m_b.eg, this.m_b.eh, A_0);
			break;
		case 1:
			this.m_b.k(ref this.m_b.hu, this.m_b.hv, A_0);
			break;
		case 2:
			this.m_b.k(ref this.m_b.hx, this.m_b.hy, A_0);
			break;
		case 3:
			this.m_b.k(ref this.m_b.h0, this.m_b.h1, A_0);
			break;
		case 4:
			this.m_b.k(ref this.m_b.h3, this.m_b.h4, A_0);
			break;
		case 5:
			this.m_b.k(ref this.m_b.h6, this.m_b.h7, A_0);
			break;
		}
		e();
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
        Debug.WriteLine(A_1.KeyCode);

        if (A_1.KeyCode == Keys.Escape)
		{
			this.m_e = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Up && this.m_d > 0)
		{
			this.m_d--;
			c();
		}
		else if (A_1.KeyCode == Keys.Down && this.m_d < 5)
		{
			this.m_d++;
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
			this.m_d = 5;
			c();
		}
		else if (A_1.KeyCode == Keys.F1)
		{
			this.m_b.ng();
		}
		else if (A_1.KeyCode == Keys.F5)
		{
			this.m_b.na();
			e();
		}
		else if (A_1.KeyCode == Keys.F7)
		{
			this.m_b.nd();
			e();
		}
		else if (A_1.KeyCode == Keys.F10)
		{
			this.m_b.l();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = this.m_e;
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
		ax = new Label();
		aw = new Label();
		ao = new Label();
		ap = new Label();
		aq = new Label();
		ar = new Label();
		@as = new Label();
		at = new Label();
		au = new Label();
		av = new Label();
		al = new Label();
		am = new Label();
		an = new Label();
		ad = new Label();
		ae = new Label();
		af = new Label();
		ag = new Label();
		ah = new Label();
		ai = new Label();
		aj = new Label();
		ak = new Label();
		u = new Label();
		v = new Label();
		w = new Label();
		x = new Label();
		m_y = new Label();
		z = new Label();
		aa = new Label();
		ab = new Label();
		ac = new Label();
		t = new Label();
		s = new Label();
		q = new Panel();
		r = new Panel();
		j = new Panel();
		ay = new Label();
		az = new Label();
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
		i.Controls.Add(ax);
		i.Controls.Add(aw);
		i.Controls.Add(ao);
		i.Controls.Add(ap);
		i.Controls.Add(aq);
		i.Controls.Add(ar);
		i.Controls.Add(@as);
		i.Controls.Add(at);
		i.Controls.Add(au);
		i.Controls.Add(av);
		i.Controls.Add(al);
		i.Controls.Add(am);
		i.Controls.Add(an);
		i.Controls.Add(ad);
		i.Controls.Add(ae);
		i.Controls.Add(af);
		i.Controls.Add(ag);
		i.Controls.Add(ah);
		i.Controls.Add(ai);
		i.Controls.Add(aj);
		i.Controls.Add(ak);
		i.Controls.Add(u);
		i.Controls.Add(v);
		i.Controls.Add(w);
		i.Controls.Add(x);
		i.Controls.Add(m_y);
		i.Controls.Add(z);
		i.Controls.Add(aa);
		i.Controls.Add(ab);
		i.Controls.Add(ac);
		i.Controls.Add(t);
		i.Controls.Add(s);
		i.Controls.Add(q);
		i.Controls.Add(r);
		i.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		i.ForeColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(12, 92);
		i.Name = "Lev_Panel";
		i.Size = new Size(868, 877);
		i.TabIndex = 2;
		ax.Location = new Point(700, 387);
		ax.Name = "End";
		ax.Size = new Size(126, 37);
		ax.TabIndex = 66;
		aw.Anchor = AnchorStyles.Top;
		aw.AutoSize = true;
		aw.Location = new Point(500, 632);
		aw.Name = "IntelSpeedStepTech_Value";
		aw.Size = new Size(97, 34);
		aw.TabIndex = 65;
		aw.Text = "label1";
		ao.AutoSize = true;
		ao.Location = new Point(22, 632);
		ao.Name = "IntelSpeedStepTech";
		ao.Size = new Size(419, 34);
		ao.TabIndex = 64;
		ao.Text = "Intel(R) SpeedStep(TM) Tech.";
		ap.Anchor = AnchorStyles.Top;
		ap.AutoSize = true;
		ap.Location = new Point(500, 598);
		ap.Name = "MaxCPUIDValueLimit_Value";
		ap.Size = new Size(97, 34);
		ap.TabIndex = 63;
		ap.Text = "label1";
		aq.Anchor = AnchorStyles.Top;
		aq.AutoSize = true;
		aq.Location = new Point(500, 564);
		aq.Name = "ExecuteDisableBit_Value";
		aq.Size = new Size(97, 34);
		aq.TabIndex = 62;
		aq.Text = "label1";
		ar.Anchor = AnchorStyles.Top;
		ar.AutoSize = true;
		ar.Location = new Point(500, 530);
		ar.Name = "CPUTMFunction_Value";
		ar.Size = new Size(97, 34);
		ar.TabIndex = 61;
		ar.Text = "label1";
		@as.AutoSize = true;
		@as.Location = new Point(22, 598);
		@as.Name = "MaxCPUIDValueLimit";
		@as.Size = new Size(331, 34);
		@as.TabIndex = 60;
		@as.Text = "Max CPUID Value Limit";
		at.AutoSize = true;
		at.Location = new Point(22, 564);
		at.Name = "ExecuteDisableBit";
		at.Size = new Size(283, 34);
		at.TabIndex = 59;
		at.Text = "Execute Disable Bit";
		au.AutoSize = true;
		au.Location = new Point(22, 530);
		au.Name = "CPUTMFunction";
		au.Size = new Size(259, 34);
		au.TabIndex = 58;
		au.Text = "CPU TM Function";
		av.Anchor = AnchorStyles.Top;
		av.AutoSize = true;
		av.Location = new Point(500, 496);
		av.Name = "C1ESupport_Value";
		av.Size = new Size(97, 34);
		av.TabIndex = 57;
		av.Text = "label1";
		al.AutoSize = true;
		al.Location = new Point(22, 496);
		al.Name = "C1ESupport";
		al.Size = new Size(191, 34);
		al.TabIndex = 56;
		al.Text = "C1E Support";
		am.Anchor = AnchorStyles.Top;
		am.AutoSize = true;
		am.Location = new Point(500, 462);
		am.Name = "CPURatioSetting_Value";
		am.Size = new Size(97, 34);
		am.TabIndex = 55;
		am.Text = "label1";
		an.AutoSize = true;
		an.Location = new Point(22, 462);
		an.Name = "CPURatioSetting";
		an.Size = new Size(264, 34);
		an.TabIndex = 54;
		an.Text = "CPU Ratio Setting";
		ad.AutoSize = true;
		ad.ForeColor = Color.FromArgb(64, 64, 64);
		ad.Location = new Point(305, 387);
		ad.Name = "RatioActualValue_INFO_Value";
		ad.Size = new Size(97, 34);
		ad.TabIndex = 53;
		ad.Text = "label1";
		ae.AutoSize = true;
		ae.ForeColor = Color.FromArgb(64, 64, 64);
		ae.Location = new Point(216, 353);
		ae.Name = "RatioStatus_INFO_Value";
		ae.Size = new Size(97, 34);
		ae.TabIndex = 52;
		ae.Text = "label1";
		af.AutoSize = true;
		af.ForeColor = Color.FromArgb(64, 64, 64);
		af.Location = new Point(216, 319);
		af.Name = "CPUID_INFO_Value";
		af.Size = new Size(97, 34);
		af.TabIndex = 51;
		af.Text = "label1";
		ag.AutoSize = true;
		ag.ForeColor = Color.FromArgb(64, 64, 64);
		ag.Location = new Point(216, 285);
		ag.Name = "CacheL2_INFO_Value";
		ag.Size = new Size(97, 34);
		ag.TabIndex = 50;
		ag.Text = "label1";
		ah.AutoSize = true;
		ah.ForeColor = Color.FromArgb(64, 64, 64);
		ah.Location = new Point(216, 251);
		ah.Name = "CacheL1_INFO_Value";
		ah.Size = new Size(97, 34);
		ah.TabIndex = 49;
		ah.Text = "label1";
		ai.AutoSize = true;
		ai.ForeColor = Color.FromArgb(64, 64, 64);
		ai.Location = new Point(216, 217);
		ai.Name = "FSBSpeed_INFO_Value";
		ai.Size = new Size(97, 34);
		ai.TabIndex = 48;
		ai.Text = "label1";
		aj.AutoSize = true;
		aj.ForeColor = Color.FromArgb(64, 64, 64);
		aj.Location = new Point(216, 183);
		aj.Name = "Frequency_INFO_Value";
		aj.Size = new Size(97, 34);
		aj.TabIndex = 47;
		aj.Text = "label1";
		ak.AutoSize = true;
		ak.ForeColor = Color.FromArgb(64, 64, 64);
		ak.Location = new Point(216, 117);
		ak.Name = "BrandString_INFO_Value";
		ak.Size = new Size(97, 34);
		ak.TabIndex = 46;
		ak.Text = "label1";
		u.AutoSize = true;
		u.ForeColor = Color.FromArgb(64, 64, 64);
		u.Location = new Point(22, 387);
		u.Name = "RatioActualValue_INFO";
		u.Size = new Size(265, 34);
		u.TabIndex = 45;
		u.Text = "Ratio Actual Value";
		v.AutoSize = true;
		v.ForeColor = Color.FromArgb(64, 64, 64);
		v.Location = new Point(22, 353);
		v.Name = "RatioStatus_INFO";
		v.Size = new Size(185, 34);
		v.TabIndex = 44;
		v.Text = "Ratio Status";
		w.AutoSize = true;
		w.ForeColor = Color.FromArgb(64, 64, 64);
		w.Location = new Point(22, 319);
		w.Name = "CPUID_INFO";
		w.Size = new Size(105, 34);
		w.TabIndex = 43;
		w.Text = "CPUID";
		x.AutoSize = true;
		x.ForeColor = Color.FromArgb(64, 64, 64);
		x.Location = new Point(22, 285);
		x.Name = "CacheL2_INFO";
		x.Size = new Size(144, 34);
		x.TabIndex = 42;
		x.Text = "Cache L2";
		m_y.AutoSize = true;
		m_y.ForeColor = Color.FromArgb(64, 64, 64);
		m_y.Location = new Point(22, 251);
		m_y.Name = "CacheL1_INFO";
		m_y.Size = new Size(144, 34);
		m_y.TabIndex = 41;
		m_y.Text = "Cache L1";
		z.AutoSize = true;
		z.ForeColor = Color.FromArgb(64, 64, 64);
		z.Location = new Point(22, 217);
		z.Name = "FSBSpeed_INFO";
		z.Size = new Size(167, 34);
		z.TabIndex = 40;
		z.Text = "FSB Speed";
		aa.AutoSize = true;
		aa.ForeColor = Color.FromArgb(64, 64, 64);
		aa.Location = new Point(22, 183);
		aa.Name = "Frequency_INFO";
		aa.Size = new Size(162, 34);
		aa.TabIndex = 39;
		aa.Text = "Frequency";
		ab.AutoSize = true;
		ab.ForeColor = Color.FromArgb(64, 64, 64);
		ab.Location = new Point(22, 117);
		ab.Name = "BrandString_INFO";
		ab.Size = new Size(190, 34);
		ab.TabIndex = 38;
		ab.Text = "Brand String";
		ac.AutoSize = true;
		ac.ForeColor = Color.FromArgb(64, 64, 64);
		ac.Location = new Point(216, 83);
		ac.Name = "Manufacturer_INFO_Value";
		ac.Size = new Size(97, 34);
		ac.TabIndex = 37;
		ac.Text = "label1";
		t.AutoSize = true;
		t.ForeColor = Color.FromArgb(64, 64, 64);
		t.Location = new Point(22, 83);
		t.Name = "Manufacturer_INFO";
		t.Size = new Size(200, 34);
		t.TabIndex = 36;
		t.Text = "Manufacturer";
		s.AutoSize = true;
		s.ForeColor = Color.Black;
		s.Location = new Point(22, 17);
		s.Name = "ConfigureadvancedCPUsettings";
		s.Size = new Size(493, 34);
		s.TabIndex = 35;
		s.Text = "Configure advanced CPU settings ";
		q.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		q.BackColor = Color.FromArgb(27, 35, 165);
		q.Location = new Point(18, 68);
		q.Name = "Goriz_1";
		q.Size = new Size(828, 2);
		q.TabIndex = 1;
		r.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		r.BackColor = Color.FromArgb(27, 35, 165);
		r.Location = new Point(18, 438);
		r.Name = "Goriz_2";
		r.Size = new Size(828, 2);
		r.TabIndex = 2;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		j.AutoScroll = true;
		j.Controls.Add(ay);
		j.Controls.Add(az);
		j.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		j.ForeColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(884, 92);
		j.Name = "Prav_Panel";
		j.Size = new Size(382, 877);
		j.TabIndex = 3;
		ay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		ay.Location = new Point(6, 590);
		ay.Name = "Help_Niz";
		ay.Size = new Size(372, 250);
		ay.TabIndex = 1;
		az.Location = new Point(6, 15);
		az.Name = "Help_Verh";
		az.Size = new Size(372, 470);
		az.TabIndex = 0;
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
		base.Name = "Advanced_CPUConfiguration_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Advanced_CPUConfiguration_Form";
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
