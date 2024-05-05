using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class a : Form
{
	private u m_a;

	private int m_b;

	private Color m_c;

	private bool d = true;

	private IContainer e;

	private Label f;

	private Panel g;

	private Panel h;

	private Panel i;

	private Panel j;

	private Panel k;

	private Label l;

	private Label m;

	public a(u A_0, string A_1)
	{
		this.m_a = A_0;
		this.m_c = Color.FromArgb(190, 190, 190);
		am();
		f.Text = A_1;
		c();
	}

	private void c()
	{
		m.ForeColor = this.m_a.g;
		m.BackColor = Color.White;
		l.ForeColor = this.m_a.g;
		l.BackColor = Color.White;
		switch (this.m_b)
		{
		case 0:
			m.ForeColor = this.m_c;
			m.BackColor = Color.Black;
			break;
		case 1:
			l.ForeColor = this.m_c;
			l.BackColor = Color.Black;
			break;
		}
	}

	private void b()
	{
		switch (f.Text)
		{
		case "Save configuration changes and exit now?":
			this.m_a.nb();
			break;
		case "Discard configuration changes and exit now?":
			this.m_a.t();
			this.m_a.nb();
			break;
		case "Discard Changes?":
		case "Load Setup Defaults?":
			this.m_a.t();
			break;
		}
	}

	private void am(object A_0, KeyEventArgs A_1)
	{
		Debug.WriteLine(A_1.KeyCode);
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
				b();
			}
			else if (this.m_b == 1)
			{
				this.m_a.m = "Cancel";
			}
			d = false;
			Close();
		}
		else if (A_1.KeyCode == Keys.Left)
		{
			if (this.m_b == 1)
			{
				this.m_b--;
			}
			c();
		}
		else if (A_1.KeyCode == Keys.Right)
		{
			if (this.m_b == 0)
			{
				this.m_b++;
			}
			c();
		}
	}

	private void am(object A_0, FormClosingEventArgs A_1)
	{
		A_1.Cancel = d;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && e != null)
		{
			e.Dispose();
		}
		base.Dispose(disposing);
	}

	private void am()
	{
		f = new Label();
		g = new Panel();
		h = new Panel();
		i = new Panel();
		j = new Panel();
		k = new Panel();
		l = new Label();
		m = new Label();
		SuspendLayout();
		f.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		f.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		f.ForeColor = Color.FromArgb(27, 35, 165);
		f.Location = new Point(21, 75);
		f.Name = "MyLabel";
		f.Size = new Size(718, 37);
		f.TabIndex = 7;
		f.Text = "Label";
		f.TextAlign = ContentAlignment.TopCenter;
		g.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		g.BackColor = Color.FromArgb(27, 35, 165);
		g.Location = new Point(12, 150);
		g.Name = "Goriz2";
		g.Size = new Size(736, 3);
		g.TabIndex = 1;
		h.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		h.BackColor = Color.FromArgb(27, 35, 165);
		h.Location = new Point(12, 22);
		h.Name = "Goriz1";
		h.Size = new Size(736, 3);
		h.TabIndex = 2;
		i.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		i.BackColor = Color.FromArgb(27, 35, 165);
		i.Location = new Point(12, 218);
		i.Name = "Goriz3";
		i.Size = new Size(736, 3);
		i.TabIndex = 3;
		j.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		j.BackColor = Color.FromArgb(27, 35, 165);
		j.Location = new Point(12, 22);
		j.Name = "Vert1";
		j.Size = new Size(3, 198);
		j.TabIndex = 5;
		k.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
		k.BackColor = Color.FromArgb(27, 35, 165);
		k.Location = new Point(745, 22);
		k.Name = "Vert2";
		k.Size = new Size(3, 198);
		k.TabIndex = 6;
		l.Anchor = AnchorStyles.Top;
		l.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		l.ForeColor = Color.FromArgb(27, 35, 165);
		l.Location = new Point(390, 165);
		l.Name = "Cancel_But";
		l.Size = new Size(130, 38);
		l.TabIndex = 8;
		l.Text = "[Cancel]";
		l.TextAlign = ContentAlignment.TopCenter;
		m.Anchor = AnchorStyles.Top;
		m.BackColor = Color.Black;
		m.Font = new Font("Arial", 21.75f, FontStyle.Bold);
		m.ForeColor = Color.FromArgb(190, 190, 190);
		m.Location = new Point(225, 165);
		m.Name = "Ok_But";
		m.Size = new Size(75, 38);
		m.TabIndex = 9;
		m.Text = "[Ok]";
		m.TextAlign = ContentAlignment.TopCenter;
		base.AutoScaleDimensions = new SizeF(19f, 37f);
		base.AutoScaleMode = AutoScaleMode.Font;
		AutoSize = true;
		BackColor = Color.White;
		base.ClientSize = new Size(760, 243);
		base.Controls.Add(f);
		base.Controls.Add(m);
		base.Controls.Add(l);
		base.Controls.Add(k);
		base.Controls.Add(g);
		base.Controls.Add(j);
		base.Controls.Add(i);
		base.Controls.Add(h);
		Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, 204);
		ForeColor = Color.FromArgb(190, 190, 190);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(10, 9, 10, 9);
		MaximumSize = new Size(760, 243);
		MinimumSize = new Size(400, 243);
		base.Name = "Exit_PopUpWindow_Form";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Exit_PopUpWindow_Form";
		base.FormClosing += am;
		base.KeyDown += am;
		ResumeLayout(performLayout: false);
	}
}
