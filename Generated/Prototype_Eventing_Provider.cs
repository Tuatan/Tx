// 
//    This code was generated by EtwEventTypeGen.exe 
//

using System;

namespace Tx.Windows.Prototype_Eventing_Provider
{
    [ManifestEvent("{3838EF9A-CB6F-4A1C-9033-84C0E8EBF5A7}", 1, 0,
    "", "win:LogAlways", "PrototypeEventing/Analytic", "MyKeyword")]

    [Format("This is a small event.")]

    public class SmallEvent : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ID { get; set; }
    }

    [ManifestEvent("{3838EF9A-CB6F-4A1C-9033-84C0E8EBF5A7}", 2, 0,
    "", "win:LogAlways", "PrototypeEventing/Analytic", "MyKeyword")]

    [Format("This is a medium event.")]

    public class MediumEvent : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ID { get; set; }

        [EventField("win:UInt32")]
        public uint number1 { get; set; }

        [EventField("win:UInt32")]
        public uint number2 { get; set; }

        [EventField("win:UnicodeString")]
        public string string1 { get; set; }

        [EventField("win:UnicodeString")]
        public string string2 { get; set; }
    }

    [ManifestEvent("{3838EF9A-CB6F-4A1C-9033-84C0E8EBF5A7}", 3, 0,
    "", "win:LogAlways", "PrototypeEventing/Analytic", "MyKeyword")]

    [Format("This is a large event.")]

    public class LargeEvent : SystemEvent
    {
        [EventField("win:UInt32")]
        public uint ID { get; set; }

        [EventField("win:UInt32")]
        public uint number1 { get; set; }

        [EventField("win:UInt32")]
        public uint number2 { get; set; }

        [EventField("win:UInt32")]
        public uint number3 { get; set; }

        [EventField("win:UInt32")]
        public uint number4 { get; set; }

        [EventField("win:UInt32")]
        public uint number5 { get; set; }

        [EventField("win:UInt32")]
        public uint number6 { get; set; }

        [EventField("win:UInt32")]
        public uint number7 { get; set; }

        [EventField("win:UInt32")]
        public uint number8 { get; set; }

        [EventField("win:UInt32")]
        public uint number9 { get; set; }

        [EventField("win:UInt32")]
        public uint number10 { get; set; }

        [EventField("win:UnicodeString")]
        public string string1 { get; set; }

        [EventField("win:UnicodeString")]
        public string string2 { get; set; }

        [EventField("win:UnicodeString")]
        public string string3 { get; set; }

        [EventField("win:UnicodeString")]
        public string string4 { get; set; }

        [EventField("win:UnicodeString")]
        public string string5 { get; set; }

        [EventField("win:UnicodeString")]
        public string string6 { get; set; }

        [EventField("win:UnicodeString")]
        public string string7 { get; set; }

        [EventField("win:UnicodeString")]
        public string string8 { get; set; }

        [EventField("win:UnicodeString")]
        public string string9 { get; set; }

        [EventField("win:UnicodeString")]
        public string string10 { get; set; }
    }

}