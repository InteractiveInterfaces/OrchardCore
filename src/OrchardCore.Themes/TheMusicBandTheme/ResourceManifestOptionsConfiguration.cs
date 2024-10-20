using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.TheMusicBandTheme;

public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static ResourceManifest _manifest;

    static ResourceManagementOptionsConfiguration()
    {
        _manifest = new ResourceManifest();

        _manifest
            .DefineScript("TheMusicBandTheme-popper-js")
            .SetUrl("~/TheMusicBandTheme/assets/plugins/popper.min.js", "~/TheMusicBandTheme/assets/plugins/popper.min.js")
            .SetVersion("1.0.0");
        
          _manifest
            .DefineScript("TheMusicBandTheme-bootstrap-js")
            .SetUrl("~/TheMusicBandTheme/assets/plugins/bootstrap/js/bootstrap.min.js", "~/TheMusicBandTheme/assets/plugins/bootstrap/js/bootstrap.min.js")
            .SetVersion("5.0.1");
        
        _manifest
            .DefineScript("TheMusicBandTheme-back-to-top-js")
            .SetUrl("~/TheMusicBandTheme/assets/plugins/vanilla-back-to-top.min.js", "~/TheMusicBandTheme/assets/plugins/vanilla-back-to-top.min.js")
            .SetVersion("1.0.0");            

        _manifest
            .DefineScript("TheMusicBandTheme-scroll-js")
            .SetUrl("~/TheMusicBandTheme/assets/plugins/smoothscroll.min.js", "~/TheMusicBandTheme/assets/plugins/smoothscroll.min.js")
            .SetVersion("1.0.0");            

        _manifest
            .DefineScript("TheMusicBandTheme-gumshoe-js")
            .SetUrl("~/TheMusicBandTheme/assets/plugins/gumshoe/gumshoe.polyfills.min.js", "~/TheMusicBandTheme/assets/plugins/gumshoe/gumshoe.polyfills.min.js")
            .SetVersion("1.0.0");            

        _manifest
            .DefineScript("TheMusicBandTheme-main-js")
            .SetUrl("~/TheMusicBandTheme/assets/js/main.js", "~/TheMusicBandTheme/assets/js/scripts.js")
            .SetVersion("1.0.0");            

        _manifest
            .DefineStyle("TheMusicBandTheme-bootstrap")                
            .SetUrl("~/TheMusicBandTheme/assets/plugins/bootstrap/css/bootstrap.min.css", "~/TheMusicBandTheme/assets/plugins/bootstrap/css/bootstrap.css")
            .SetVersion("5.0.1");

        _manifest
            .DefineStyle("TheMusicBandTheme-oc")
            .SetDependencies("TheMusicBandTheme-bootstrap")
            .SetUrl("~/TheMusicBandTheme/assets/css/theme-4.css", "~/TheMusicBandTheme/assets/css/theme-4.css")
            .SetVersion("1.0.0");

        _manifest
           .DefineScript("TheMusicBandTheme-fontawesome-js")
           .SetUrl("~/TheMusicBandTheme/assets/fontawesome/js/all.min.js", "~/TheMusicBandTheme/assets/fontawesome/js/all.js")
           .SetVersion("5.15.3");
    }

    public void Configure(ResourceManagementOptions options)
    {
        options.ResourceManifests.Add(_manifest);
    }
}
