
namespace MyNotes
{
    static class SharedResources
    {
        public static readonly Color FontColor = Color.FromRgb(0,0,0);

        public static readonly Color BackgroundColor = Color.FromRgb(27, 112, 182);
    }

}

// this is not compatible on older windows, and older apple ios and macos 
// build results in a CA1416 violation 
// for best practic, need to using platform specific methods