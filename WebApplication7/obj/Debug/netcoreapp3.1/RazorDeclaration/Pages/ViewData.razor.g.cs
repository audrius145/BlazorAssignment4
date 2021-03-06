#pragma checksum "D:\.net\Solution1\WebApplication7\Pages\ViewData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f7e88533ec3b48da20db89c66fde70d2dfadc00"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using WebApplication7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using WebApplication7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.net\Solution1\WebApplication7\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.net\Solution1\WebApplication7\Pages\ViewData.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.net\Solution1\WebApplication7\Pages\ViewData.razor"
using WebApplication7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\.net\Solution1\WebApplication7\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/view")]
    public partial class ViewData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "D:\.net\Solution1\WebApplication7\Pages\ViewData.razor"
       
    private IList<Adult> allAdults;
    private IList<Adult> adultsToShow;
    private int? adultID;
    private string? adultName;
    private int? adultAge;
    private string? adultLastName;
    private string? adultHair;
    private string? adultEye;
    private float? adultWeight;
    private float? adultHeight;
    private string? adultProfession;
    private string? adultSex;

    protected override async Task OnInitializedAsync()
    {
        allAdults = await AdultService.getAdultsAsync();
        adultsToShow = allAdults;
    }


    private void FilterById(ChangeEventArgs args)
    {
        adultID = null;
        try
        {
            adultID = int.Parse(args.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByEye(ChangeEventArgs args)
    {
        adultEye = null;
        try
        {
            adultEye = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByProfession(ChangeEventArgs args)
    {
        adultProfession = null;
        try
        {
            adultProfession = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByAge(ChangeEventArgs arg)
    {
        adultAge = null;
        try
        {
            adultAge = int.Parse(arg.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByWeight(ChangeEventArgs arg)
    {
        adultWeight = null;
        try
        {
            adultWeight = float.Parse(arg.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByHeight(ChangeEventArgs args)
    {
        adultHeight = null;
        try
        {
            adultHeight = float.Parse(args.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByName(ChangeEventArgs args)
    {
        adultName = null;
        try
        {
            adultName = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByHair(ChangeEventArgs args)
    {
        adultHair = null;
        try
        {
            adultHair = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByLastName(ChangeEventArgs args)
    {
        adultLastName = null;
        try
        {
            adultLastName = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterBySex(ChangeEventArgs args)
    {
        adultSex = null;
        try
        {
            adultSex = args.Value.ToString();
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        adultsToShow = allAdults.Where(t => (adultID != null && t.Id == adultID || adultID == null)
                                            && (!string.IsNullOrEmpty(adultName) && t.FirstName == adultName || string.IsNullOrEmpty(adultName))
                                            && (adultAge != null && t.Age == adultAge || adultAge == null)
                                            && (!string.IsNullOrEmpty(adultLastName) && t.LastName == adultLastName || string.IsNullOrEmpty(adultLastName))
                                            && (!string.IsNullOrEmpty(adultHair) && t.HairColor == adultHair || string.IsNullOrEmpty(adultHair))
                                            && (!string.IsNullOrEmpty(adultEye) && t.EyeColor == adultEye || string.IsNullOrEmpty(adultEye))
                                            && (adultWeight != null && t.Weight == adultWeight || adultWeight == null)
                                            && (adultHeight != null && t.Height == adultHeight || adultHeight == null)
                                            && (!string.IsNullOrEmpty(adultSex) && t.Sex == adultSex || string.IsNullOrEmpty(adultSex))
                                            && (!string.IsNullOrEmpty(adultProfession) && t.JobTitle == adultProfession || string.IsNullOrEmpty(adultProfession))).ToList();
    }

    private async Task RemoveAdultAsync(int adultID)
    {
        Adult adultToRemove = allAdults.First(t => t.Id == adultID);
        await AdultService.RemoveAdultAsync(adultID);
        adultsToShow.Remove(adultToRemove);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
