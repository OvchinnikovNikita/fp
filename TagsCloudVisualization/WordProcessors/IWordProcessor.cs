﻿using TagsCloudVisualization.WordProcessors.WordProcessingSettings;

namespace TagsCloudVisualization.WordProcessors
{
    public interface IWordProcessor
    {
        public IProcessingSettings Settings { get; }
        public Result<string[]> Process(string[] words);
        public bool WordIsAllowed(string word);
    }
}
