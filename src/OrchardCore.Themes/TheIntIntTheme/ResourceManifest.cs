using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace OrchardCore.Themes.TheIntIntTheme;

public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static ResourceManifest manifest;

    static ResourceManagementOptionsConfiguration()
    {
        manifest = new ResourceManifest();

        manifest
            .DefineScript("TheIntIntTheme-vendor-jQuery")
            .SetUrl("~/TheIntIntTheme/vendor/jquery/jquery.min.js", "~/TheIntIntTheme/vendor/jquery/jquery.js")
            .SetCdn("https://code.jquery.com/jquery-3.4.1.min.js", "https://code.jquery.com/jquery-3.4.1.js")
            .SetCdnIntegrity("sha384-vk5WoKIaW/vJyUAd9n/wmopsmNhiy+L2Z+SBxGYnUkunIxVxAv/UtMOhba/xskxh", "sha384-mlceH9HlqLp7GMKHrj5Ara1+LvdTZVMx4S1U43/NxCvAkzIo8WJ0FE7duLel3wVo")
            .SetVersion("3.4.1");

        manifest
            .DefineScript("TheIntIntTheme-vendor-jQuery.slim")
            .SetUrl("~/TheIntIntTheme/vendor/jquery/jquery.slim.min.js", "~/TheIntIntTheme/vendor/jquery/jquery.slim.js")
            .SetCdn("https://code.jquery.com/jquery-3.4.1.slim.min.js", "https://code.jquery.com/jquery-3.4.1.slim.js")
            .SetCdnIntegrity("sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n", "sha384-teRaFq/YbXOM/9FZ1qTavgUgTagWUPsk6xapwcjkrkBHoWvKdZZuAeV8hhaykl+G")
            .SetVersion("3.4.1");

        manifest
            .DefineScript("TheIntIntTheme-vendor-jQuery.easing")
            .SetDependencies("TheIntIntTheme-vendor-jQuery")
            .SetUrl("~/TheIntIntTheme/vendor/jquery-easing/jquery.easing.min.js", "~/TheIntIntTheme/vendor/jquery-easing/jquery.easing.js")
            .SetCdn("https://cdn.jsdelivr.net/npm/jquery.easing@1.4.1/jquery.easing.min.js", "https://cdn.jsdelivr.net/npm/jquery.easing@1.4.1/jquery.easing.js")
            .SetCdnIntegrity("sha384-leGYpHE9Tc4N9OwRd98xg6YFpB9shlc/RkilpFi0ljr3QD4tFoFptZvgnnzzwG4Q", "sha384-fwPA0FyfPOiDsglgAC4ZWmBGwpXSZNkq9IG+cM9HL4CkpNQo4xgCDkOIPdWypLMX")
            .SetVersion("1.4.1");

        manifest
            .DefineScript("TheIntIntTheme-vendor-bootstrap")
            .SetDependencies("TheIntIntTheme-vendor-jQuery")
            .SetUrl("~/TheIntIntTheme/vendor/bootstrap/js/bootstrap.min.js", "~/TheIntIntTheme/vendor/bootstrap/js/bootstrap.js")
            .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js", "https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.js")
            .SetCdnIntegrity("sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM", "sha384-rkSGcquOAzh5YMplX4tcXMuXXwmdF/9eRLkw/gNZG+1zYutPej7fxyVLiOgfoDgi")
            .SetVersion("4.3.1");

        manifest
            .DefineScript("TheIntIntTheme-vendor-bootstrap-bundle")
            .SetDependencies("TheIntIntTheme-vendor-jQuery")
            .SetUrl("~/TheIntIntTheme/vendor/bootstrap/js/bootstrap.bundle.min.js", "~/TheIntIntTheme/vendor/bootstrap/js/bootstrap.bundle.js")
            .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js", "https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.js")
            .SetCdnIntegrity("sha384-xrRywqdh3PHs8keKZN+8zzc5TX0GRTLCcmivcbNJWm2rs5C8PRhcEn3czEjhAO9o", "sha384-szbKYgPl66wivXHlSpJF+CKDAVckMVnlGrP25Sndhe+PwOBcXV9LlFh4MUpRhjIB")
            .SetVersion("4.3.1");

        manifest
            .DefineStyle("TheIntIntTheme-vendor-bootstrap")
            .SetUrl("~/TheIntIntTheme/vendor/bootstrap/css/bootstrap.min.css", "~/TheIntIntTheme/vendor/bootstrap/css/bootstrap.css")
            .SetCdn("https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css", "https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.css")
            .SetCdnIntegrity("sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T", "sha384-t4IGnnWtvYimgcRMiXD2ZD04g28Is9vYsVaHo5LcWWJkoQGmMwGg+QS0mYlhbVv3")
            .SetVersion("4.3.1");

        manifest
            .DefineStyle("TheIntIntTheme-bootstrap-oc")
            .SetUrl("~/TheIntIntTheme/css/bootstrap-oc.min.css", "~/TheIntIntTheme/css/bootstrap-oc.css")
            .SetVersion("1.0.0");
				
        manifest
            .DefineStyle("TheIntIntTheme-vendor-font-awesome")
            .SetUrl("~/TheIntIntTheme/vendor/fontawesome-free/css/all.min.css", "~/TheIntIntTheme/vendor/fontawesome-free/css/all.css")
            .SetCdn("https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.10.2/css/all.min.css", "https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.10.2/css/all.css")
            .SetCdnIntegrity("sha384-rtJEYb85SiYWgfpCr0jn174XgJTn4rptSOQsMroFBPQSGLdOC5IbubP6lJ35qoM9", "sha384-Ex0vLvgbKZTFlqEetkjk2iUgM+H5udpQKFKjBoGFwPaHRGhiWyVI6jLz/3fBm5ht")
            .SetVersion("5.10.2");

        manifest
            .DefineScript("TheIntIntTheme-vendor-font-awesome")
            .SetCdn("https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.10.2/js/all.min.js", "https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.10.2/js/all.js")
            .SetCdnIntegrity("sha384-QMu+Y+eu45Nfr9fmFOlw8EqjiUreChmoQ7k7C1pFNO8hEbGv9yzsszTmz+RzwyCh", "sha384-7/I8Wc+TVwiZpEjE4qTV6M27LYR5Dus6yPGzQZowRtgh+0gDW9BNR9GmII1/YwmG")
            .SetVersion("5.10.2");
    }

    public void Configure(ResourceManagementOptions options)
    {
        options.ResourceManifests.Add(manifest);
    }
}
