﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;

public partial class views_global_sysprep_search : BasePages.Global
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

        PopulateGrid();
    }

    protected void PopulateGrid()
    {
        var bllSysprepTag = new BLL.SysprepTag();
        gvSysprepTags.DataSource = bllSysprepTag.SearchSysprepTags(txtSearch.Text);
        gvSysprepTags.DataBind();

        lblTotal.Text = gvSysprepTags.Rows.Count + " Result(s) / " + bllSysprepTag.TotalCount() + " Total Sysprep Tag(s)";
    }

    protected void search_Changed(object sender, EventArgs e)
    {
        PopulateGrid();
    }

    protected void chkSelectAll_CheckedChanged(object sender, EventArgs e)
    {
        ChkAll(gvSysprepTags);
    }



    protected void gridView_Sorting(object sender, GridViewSortEventArgs e)
    {
        PopulateGrid();
        List<SysprepTag> listSysprepTags = (List<SysprepTag>)gvSysprepTags.DataSource;
        switch (e.SortExpression)
        {
            case "Name":
                listSysprepTags = GetSortDirection(e.SortExpression) == "Asc" ? listSysprepTags.OrderBy(s => s.Name).ToList() : listSysprepTags.OrderByDescending(s => s.Name).ToList();
                break;
            case "OpeningTag":
                listSysprepTags = GetSortDirection(e.SortExpression) == "Asc" ? listSysprepTags.OrderBy(s => s.OpeningTag).ToList() : listSysprepTags.OrderByDescending(s => s.OpeningTag).ToList();
                break;

        }


        gvSysprepTags.DataSource = listSysprepTags;
        gvSysprepTags.DataBind();
    }
}