using Xamarin.Forms;

namespace DuolingoClone.Behaviors
{
    public class ListViewDeselectItemBehavior : Behavior<ListView>
    {
        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.ItemSelected += ListViewItemSelect;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.ItemSelected -= ListViewItemSelect;
        }

        private void ListViewItemSelect(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}
