using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MyBIOS.Properties;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
public class Resources
{
	private static ResourceManager a;

	private static CultureInfo b;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(a, null))
			{
				ResourceManager resourceManager = new ResourceManager("MyBIOS.Properties.Resources", typeof(Resources).Assembly);
				a = resourceManager;
			}
			return a;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return b;
		}
		set
		{
			b = value;
		}
	}

	public static Bitmap Advanced
	{
		get
		{
			object @object = ResourceManager.GetObject("Advanced", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap AdvancedOnly
	{
		get
		{
			object @object = ResourceManager.GetObject("AdvancedOnly", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap Back
	{
		get
		{
			object @object = ResourceManager.GetObject("Back", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap Back_d
	{
		get
		{
			object @object = ResourceManager.GetObject("Back_d", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap Boot
	{
		get
		{
			object @object = ResourceManager.GetObject("Boot", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap BootOnly
	{
		get
		{
			object @object = ResourceManager.GetObject("BootOnly", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap Exit
	{
		get
		{
			object @object = ResourceManager.GetObject("Exit", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap Forward
	{
		get
		{
			object @object = ResourceManager.GetObject("Forward", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap Forward_d
	{
		get
		{
			object @object = ResourceManager.GetObject("Forward_d", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap Main
	{
		get
		{
			object @object = ResourceManager.GetObject("Main", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap MainOnly
	{
		get
		{
			object @object = ResourceManager.GetObject("MainOnly", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap NizAll
	{
		get
		{
			object @object = ResourceManager.GetObject("NizAll", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap Power
	{
		get
		{
			object @object = ResourceManager.GetObject("Power", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap PowerOnly
	{
		get
		{
			object @object = ResourceManager.GetObject("PowerOnly", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap ShapkaAll
	{
		get
		{
			object @object = ResourceManager.GetObject("ShapkaAll", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap Tools
	{
		get
		{
			object @object = ResourceManager.GetObject("Tools", b);
			return (Bitmap)@object;
		}
	}

	public static Bitmap Warning
	{
		get
		{
			object @object = ResourceManager.GetObject("Warning", b);
			return (Bitmap)@object;
		}
	}

	internal Resources()
	{
	}
}
