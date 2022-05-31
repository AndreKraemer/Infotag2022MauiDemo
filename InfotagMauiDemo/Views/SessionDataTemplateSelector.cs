using InfotagMauiDemo.Models;

namespace InfotagMauiDemo.Views;

public class SessionDataTemplateSelector : DataTemplateSelector
{
    public DataTemplate SessionTemplate { get; set; }
    public DataTemplate BreakTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return (item as Session)?.Speaker != null ? SessionTemplate : BreakTemplate;
    }
}
