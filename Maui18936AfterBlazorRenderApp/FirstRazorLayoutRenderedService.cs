namespace Maui18936AfterBlazorRenderApp
{
    public class FirstRazorLayoutRenderedService
    {
        private bool _firstRazorLayoutRendered;

        /// <summary>
        /// This event is raised ONE time after the Razor layout has been rendered.
        /// </summary>
        public event EventHandler? FirstRazorLayoutRendered;

        /// <summary>
        /// Raises the event <see cref="FirstRazorLayoutRendered"/> ONE time after the Razor layout has been rendered.
        /// Calling this method more than once has no effect.
        /// </summary>
        public void OnFirstRazorLayoutRendered()
        {
            if (!_firstRazorLayoutRendered)
            {
                _firstRazorLayoutRendered = true;
                FirstRazorLayoutRendered?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
