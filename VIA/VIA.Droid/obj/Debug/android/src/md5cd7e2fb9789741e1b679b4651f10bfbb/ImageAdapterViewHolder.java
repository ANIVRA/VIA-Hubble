package md5cd7e2fb9789741e1b679b4651f10bfbb;


public class ImageAdapterViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("VIA.Droid.Adapters.ImageAdapterViewHolder, VIA.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ImageAdapterViewHolder.class, __md_methods);
	}


	public ImageAdapterViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ImageAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("VIA.Droid.Adapters.ImageAdapterViewHolder, VIA.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

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
