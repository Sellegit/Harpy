using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
//using mono

namespace Harpy {

	[Model, BaseType (typeof (NSObject))]
	public partial interface HarpyDelegate {

		[Export ("harpyDidShowUpdateDialog")]
		void HarpyDidShowUpdateDialog ();

		[Export ("harpyUserDidLaunchAppStore")]
		void HarpyUserDidLaunchAppStore ();

		[Export ("harpyUserDidSkipVersion")]
		void HarpyUserDidSkipVersion ();

		[Export ("harpyUserDidCancel")]
		void HarpyUserDidCancel ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface Harpy {

		[Export ("delegate", ArgumentSemantic.Assign)]
		HarpyDelegate Delegate { get; set; }

		[Export ("appID", ArgumentSemantic.Retain)]
		string AppID { get; set; }

		[Export ("appName", ArgumentSemantic.Retain)]
		string AppName { get; set; }

		[Export ("alertType")]
		HarpyAlertType AlertType { get; set; }

		[Export ("patchUpdateAlertType")]
		HarpyAlertType PatchUpdateAlertType { get; set; }

		[Export ("minorUpdateAlertType")]
		HarpyAlertType MinorUpdateAlertType { get; set; }

		[Export ("majorUpdateAlertType")]
		HarpyAlertType MajorUpdateAlertType { get; set; }

		[Export ("countryCode", ArgumentSemantic.Copy)]
		string CountryCode { get; set; }

		[Export ("forceLanguageLocalization", ArgumentSemantic.Copy)]
		string ForceLanguageLocalization { get; set; }

		[Static, Export ("sharedInstance")]
		Harpy SharedInstance { get; }

		[Export ("checkVersion")]
		void CheckVersion ();

		[Export ("checkVersionDaily")]
		void CheckVersionDaily ();

		[Export ("checkVersionWeekly")]
		void CheckVersionWeekly ();
	}
}
