﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace Microsoft.CodeAnalysis.CodeLens
{
    /// <summary>
    /// Holds information required to display and navigate to individual references
    /// </summary>
    internal sealed class ReferenceLocationDescriptor
    {
        public int LineNumber { get; }

        public int ColumnNumber { get; }

        public Guid ProjectGuid { get; }

        public Guid DocumentGuid { get; }

        /// <summary>
        /// Language of the reference location
        /// </summary>
        public string Language { get; }

        /// <summary>
        /// Fully qualified name of the symbol containing the reference location
        /// </summary>
        public string LongDescription { get; }

        /// <summary>
        /// The kind of symbol containing the reference location (such as type, method, property, etc.)
        /// </summary>
        public Glyph? Glyph { get; }

        /// <summary>
        /// the full line of source that contained the reference
        /// </summary>
        public string ReferenceLineText { get; }

        /// <summary>
        /// the beginning of the span within reference text that was the use of the reference
        /// </summary>
        public int ReferenceStart { get; }

        /// <summary>
        /// the length of the span of the reference
        /// </summary>
        public int ReferenceLength { get; }

        /// <summary>
        /// Text above the line with the reference
        /// </summary>
        public string BeforeReferenceText1 { get; }

        /// <summary>
        /// Text above the line with the reference
        /// </summary>
        public string BeforeReferenceText2 { get; }

        /// <summary>
        /// Text below the line with the reference
        /// </summary>
        public string AfterReferenceText1 { get; }

        /// <summary>
        /// Text below the line with the reference
        /// </summary>
        public string AfterReferenceText2 { get; }

        public ReferenceLocationDescriptor(string longDescription, string language, Glyph? glyph, int lineNumber, int columnNumber, Guid projectGuid, Guid documentGuid, string referenceLineText, int referenceStart, int referenceLength, string beforeReferenceText1, string beforeReferenceText2, string afterReferenceText1, string afterReferenceText2)
        {
            LongDescription = longDescription;
            Language = language;
            Glyph = glyph;
            LineNumber = lineNumber;
            ColumnNumber = columnNumber;
            // We want to keep track of the location's document if it comes from a file in your solution.
            ProjectGuid = projectGuid;
            DocumentGuid = documentGuid;
            ReferenceLineText = referenceLineText;
            ReferenceStart = referenceStart;
            ReferenceLength = referenceLength;
            BeforeReferenceText1 = beforeReferenceText1;
            BeforeReferenceText2 = beforeReferenceText2;
            AfterReferenceText1 = afterReferenceText1;
            AfterReferenceText2 = afterReferenceText2;
        }
    }
}
