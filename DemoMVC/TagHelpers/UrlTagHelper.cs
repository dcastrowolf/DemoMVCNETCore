using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace DemoMVC.TagHelpers
{

    public enum TargetEnum
    {
        None = 0,
        Blank,
        Parent,
        Self,
        Top
    }

    public class UrlTagHelper : TagHelper
    {
        public TargetEnum Target { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Defines an <a /> tag
            output.TagName = "a";
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            //takes the content of the tag helper and used un the href attribute of <a/> tag
            var content = await output.GetChildContentAsync();
            output.Attributes.SetAttribute("href", content.GetContent());
            if (Target != TargetEnum.None)
            {
                output.Attributes.SetAttribute("target", $"_{Target.ToString().ToLowerInvariant()}");
            }
        }
    }
}
