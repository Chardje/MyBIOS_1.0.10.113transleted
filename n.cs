using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class n : Form
{
	private u m_a;

	private int m_b;

	private Color m_c;

	private bool d = true;

	private bool e;

	private IContainer f;

	private Label g;

	private Panel h;

	private Panel i;

	private Panel j;

	private Panel k;

	private Panel l;

	private Label m;

	private Label m_n;

	public n(u A_0, string A_1, bool A_2)
	{
		this.m_a = A_0;
		e = A_2;
		this.m_c = Color.FromArgb(190, 190, 190);
		a();
		c();
		g.Text = A_1;
		b();
	}

	private void c()
	{
		if (!e)
		{
			m.Visible = false;
			m_n.Location = new Point(m_n.Location.X + 90, m_n.Location.Y);
		}
	}

	private void b()
	{
		m_n.ForeColor = this.m_a.g;
		m_n.BackColor = Color.White;
		m.ForeColor = this.m_a.g;
		m.BackColor = Color.White;
		switch (this.m_b)
		{
		case 0:
			m_n.ForeColor = this.m_c;
			m_n.BackColor = Color.Black;
			break;
		case 1:
			m.ForeColor = this.m_c;
			m.BackColor = Color.Black;
			break;
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		if (A_1.KeyCode == Keys.Escape)
		{
			this.m_a.m = "Cancel";
			d = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Return)
		{
			if (this.m_b == 0)
			{
				this.m_a.m = "Ok";
			}
			else if (this.m_b == 1)
			{
				this.m_a.m = "Cancel";
			}
			d = false;
			Close();
		}
		if (!e)
		{
			return;
		}
		if (A_1.KeyCode == Keys.Left)
		{
			if (this.m_b == 1)
			{
				this.m_b--;
			}
			b();
		}
		else if (A_1.KeyCode == Keys.Right)
		{
			if (this.m_b == 0)
			{
				this.m_b++;
			}
			b();
		}
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = d;
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
		g = new Label();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		l = new Panel();
		m = new Label();
		m_n = new Label();
		SuspendLayout();
		g.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		g.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		g.ForeColor = Color.FromArgb(27, 35, 165);
		g.Location = new Point(21, 75);
		g.Name = "MyLabel";
		g.Size = new Size(458, 37);
		g.TabIndex = 7;
		g.Text = "Label";
		g.TextAlign = ContentAlignment.TopCenter;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		h.BackColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(12, 150);
		h.Name = "Goriz2";
		h.Size = new Size(476, 3);
		h.TabIndex = 1;
		i.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		i.BackColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(12, 22);
		i.Name = "Goriz1";
		i.Size = new Size(476, 3);
		i.TabIndex = 2;
		j.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		j.BackColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(12, 218);
		j.Name = "Goriz3";
		j.Size = new Size(476, 3);
		j.TabIndex = 3;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		k.BackColor = Color.FromArgb(27, 35, 165);
		k.Location = new Point(12, 22);
		k.Name = "Vert1";
		k.Size = new Size(3, 198);
		k.TabIndex = 5;
		l.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		l.BackColor = Color.FromArgb(27, 35, 165);
		l.Location = new Point(485, 22);
		l.Name = "Vert2";
		l.Size = new Size(3, 198);
		l.TabIndex = 6;
		m.Anchor = AnchorStyles.Top;
		m.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		m.ForeColor = Color.FromArgb(27, 35, 165);
		m.Location = new Point(237, 165);
		m.Name = "Cancel_But";
		m.Size = new Size(130, 38);
		m.TabIndex = 8;
		m.Text = "[Cancel]";
		m.TextAlign = ContentAlignment.TopCenter;
		m_n.Anchor = AnchorStyles.Top;
		m_n.BackColor = Color.Black;
		m_n.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		m_n.ForeColor = Color.FromArgb(190, 190, 190);
		m_n.Location = new Point(118, 165);
		m_n.Name = "Ok_But";
		m_n.Size = new Size(75, 38);
		m_n.TabIndex = 9;
		m_n.Text = "[Ok]";
		m_n.TextAlign = ContentAlignment.TopCenter;
		base.AutoScaleDimensions = new SizeF(19f, 37f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.White;
		base.ClientSize = new Size(500, 243);
		base.Controls.Add(g);
		base.Controls.Add(m_n);
		base.Controls.Add(m);
		base.Controls.Add(l);
		base.Controls.Add(h);
		base.Controls.Add(k);
		base.Controls.Add(j);
		base.Controls.Add(i);
		Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ForeColor = Color.FromArgb(190, 190, 190);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(10, 9, 10, 9);
		base.Name = "Boot_Security_PopUpWindow_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Boot_Security_PopUpWindow_Form";
		base.FormClosing += a;
		base.KeyDown += a;
		ResumeLayout(performLayout: false);
	}
}
