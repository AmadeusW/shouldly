﻿using System;

#if !PORTABLE
namespace Shouldly.Configuration
{
    public class ShouldMatchConfiguration
    {
        public ShouldMatchConfiguration()
        {
        }

        public ShouldMatchConfiguration(ShouldMatchConfiguration initialConfig)
        {
            StringCompareOptions = initialConfig.StringCompareOptions;
            FilenameDescriminator = initialConfig.FilenameDescriminator;
            PreventDiff = initialConfig.PreventDiff;
            FileExtension = initialConfig.FileExtension;
            TestMethodFinder = initialConfig.TestMethodFinder;
            ApprovalFileSubFolder = initialConfig.ApprovalFileSubFolder;
            Scrubber = initialConfig.Scrubber;
        }

        public StringCompareShould StringCompareOptions { get; set; }
        public string FilenameDescriminator { get; set; }
        public bool PreventDiff { get; set; }
        /// <summary>
        /// File extension without the .
        /// </summary>
        public string FileExtension { get; set; }

        public ITestMethodFinder TestMethodFinder { get; set; }
        public string ApprovalFileSubFolder { get; set; }
        /// <summary>
        /// Scrubbers allow you to alter the received document before comparing it to approved.
        /// 
        /// This is useful for replacing dates or dynamic data with fixed data
        /// </summary>
        public Func<string, string> Scrubber { get; set; }
    }
}
#endif