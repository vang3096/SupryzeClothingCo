package md54a6a1512561202e36e16e0165a56aef0;


public class BrowseItemDetailActivity
	extends md54a6a1512561202e36e16e0165a56aef0.BaseActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onStart:()V:GetOnStartHandler\n" +
			"n_onStop:()V:GetOnStopHandler\n" +
			"";
		mono.android.Runtime.register ("SupryzeClothingCo.Droid.BrowseItemDetailActivity, SupryzeClothingCo.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BrowseItemDetailActivity.class, __md_methods);
	}


	public BrowseItemDetailActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BrowseItemDetailActivity.class)
			mono.android.TypeManager.Activate ("SupryzeClothingCo.Droid.BrowseItemDetailActivity, SupryzeClothingCo.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onStart ()
	{
		n_onStart ();
	}

	private native void n_onStart ();


	public void onStop ()
	{
		n_onStop ();
	}

	private native void n_onStop ();

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
