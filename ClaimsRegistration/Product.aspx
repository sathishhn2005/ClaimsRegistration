<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="ClaimsRegistration.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/css/style.css" rel="stylesheet" />
    <div class="container">
        <div class="row">

            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">
                            
                            <img src="Content/Img/cake2.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60%Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake9.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake3.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake4.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake5.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake6.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake7.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake8.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
 
              <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">
                            
                            <img src="Content/Img/cake9.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake10.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake20.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake12.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake13.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake14.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake15.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4 col-lg-3">
                <div class="card shadow-sm product mb-4">
                    <div class="card-body">
                        <figure class="text-center">

                            <img src="Content/Img/cake17.jpg" alt="" style="max-height: 180px;" class="card-img-top">
                        </figure>
                        <p class="mb-1">
                            <small class="text-opac">Fresh</small>
                            <small class="float-end"><span class="text-opac">60% Off</span></small>
                        </p>
                        <a href="product.html" class="text-normal">
                            <h6 class="text-color-theme">ProductName</h6>
                        </a>
                        <div class="row">
                            <div class="col">
                                <p class="mb-0">$25 <small><del class="ps-2">$ 35</del></small><br>
                                    <small class="text-opac">Qty: 2</small></p>
                            </div>
                            <div class="col-auto">
                                <a onclick="currentItem('@item.UserId', '@item.Name', '@item.image', '@item.OfferPrice', '@item.SavingPercentage', '@item.CategoryId')" href="javascript:void(0);" class="btn btn-sm avatar avatar-30 p-0 rounded-circle shadow btn-gradient">
                                    <i class="fa fa-plus size-22"></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
 
        </div>
    </div>
</asp:Content>


