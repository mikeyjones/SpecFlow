﻿using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
	"VisualStudio.SpecFlow",
	Namespace = "VisualStudio.SpecFlow",
	Version = "1.12.0.0"
)]

[assembly: AddinName("SpecFlow Support")]
[assembly: AddinCategory("IDE extensions")]
[assembly: AddinDescription("Integrates SpecFlow into the MonoDevelop/Visual Studio Mac IDE.")]
[assembly: AddinAuthor("TechTalk, SineSignal, Mike Jones, Jim Bennett")]
