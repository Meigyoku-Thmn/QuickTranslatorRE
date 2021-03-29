using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace QuickTranslator
{
	// Token: 0x02000015 RID: 21
	[GeneratedCode("ICSharpCode.SettingsEditor.SettingsCodeGeneratorTool", "4.3.1.9430")]
	[CompilerGenerated]
	internal sealed partial class PostTTVFormSettings : ApplicationSettingsBase
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00011521 File Offset: 0x00010521
		public static PostTTVFormSettings Default
		{
			get
			{
				return PostTTVFormSettings.defaultInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00011528 File Offset: 0x00010528
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0001153A File Offset: 0x0001053A
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string discussionUrl
		{
			get
			{
				return (string)this["discussionUrl"];
			}
			set
			{
				this["discussionUrl"] = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00011548 File Offset: 0x00010548
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0001155A File Offset: 0x0001055A
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string line1
		{
			get
			{
				return (string)this["line1"];
			}
			set
			{
				this["line1"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00011568 File Offset: 0x00010568
		// (set) Token: 0x06000127 RID: 295 RVA: 0x0001157A File Offset: 0x0001057A
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string line2
		{
			get
			{
				return (string)this["line2"];
			}
			set
			{
				this["line2"] = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00011588 File Offset: 0x00010588
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0001159A File Offset: 0x0001059A
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string line3
		{
			get
			{
				return (string)this["line3"];
			}
			set
			{
				this["line3"] = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000115A8 File Offset: 0x000105A8
		// (set) Token: 0x0600012B RID: 299 RVA: 0x000115BA File Offset: 0x000105BA
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string line4
		{
			get
			{
				return (string)this["line4"];
			}
			set
			{
				this["line4"] = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000115C8 File Offset: 0x000105C8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000115DA File Offset: 0x000105DA
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool spoilerHanViet
		{
			get
			{
				return (bool)this["spoilerHanViet"];
			}
			set
			{
				this["spoilerHanViet"] = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000115ED File Offset: 0x000105ED
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000115FF File Offset: 0x000105FF
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool spoilerTrung
		{
			get
			{
				return (bool)this["spoilerTrung"];
			}
			set
			{
				this["spoilerTrung"] = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00011612 File Offset: 0x00010612
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00011624 File Offset: 0x00010624
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool spoilerViet
		{
			get
			{
				return (bool)this["spoilerViet"];
			}
			set
			{
				this["spoilerViet"] = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00011637 File Offset: 0x00010637
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00011649 File Offset: 0x00010649
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool spoilerVietPhraseOneMeaning
		{
			get
			{
				return (bool)this["spoilerVietPhraseOneMeaning"];
			}
			set
			{
				this["spoilerVietPhraseOneMeaning"] = value;
			}
		}

		// Token: 0x04000154 RID: 340
		private static PostTTVFormSettings defaultInstance = (PostTTVFormSettings)SettingsBase.Synchronized(new PostTTVFormSettings());
	}
}
