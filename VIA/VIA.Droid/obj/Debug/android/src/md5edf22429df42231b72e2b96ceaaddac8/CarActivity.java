package md5edf22429df42231b72e2b96ceaaddac8;


public class CarActivity
	extends md5edf22429df42231b72e2b96ceaaddac8.BaseActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("VIA.Droid.CarActivity, VIA.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CarActivity.class, __md_methods);
	}


	public CarActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CarActivity.class)
			mono.android.TypeManager.Activate ("VIA.Droid.CarActivity, VIA.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
