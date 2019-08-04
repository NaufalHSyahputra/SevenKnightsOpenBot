using System.Collections.Generic;

namespace SevenKnightsAI.Classes
{
    internal class ProfileComboBoxItem
    {
        public ProfileComboBoxItem(KeyValuePair<string, AISettings> entry)
        {
            Key = entry.Key;
            Text = Key.Substring(Key.IndexOf('\\') + 1).Replace(AIProfiles.FILE_EXTENSION, "");
            Value = entry.Value;
        }

        public override string ToString()
        {
            return Text;
        }

        public string Key;

        public string Text;

        public AISettings Value;
    }
}