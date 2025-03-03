
namespace OneLogin
{
    /// <summary>
    /// While the OneLogin admin interface offers a robust set of tools for customizing your organization’s brand in OneLogin, 
    /// the Branding API allows you even more customization with advanced features like granular message templates for SMS and email notifications 
    /// and even the ability to create multiple different brands within a single OneLogin tenant.
    /// </summary>
    public partial class OneLoginClient
    {
        #region Brands
        /// <summary>
        /// Use this API to return a list of account branding configuration objects
        /// </summary>
        /// <returns>Returns the serialized <see cref="ListBrandsResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<ListBrandsResponse>>> ListBrands()
        {
            return await GetResource<List<ListBrandsResponse>>($"{Endpoints.ONELOGIN_BRANDING}", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to retrieve a single Account Brand configuration.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <returns></returns>
        public async Task<ApiResponse<GetBrandsResponse>> GetBrands(int brandId)
        {
            return await GetResource<GetBrandsResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}", Endpoints.BaseApiVersion2);

        }

        /// <summary>
        /// Use this API to create a new branding configuration.
        /// On successful creation of a new Account Brand an id value will be returned in the response.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="GetBrandsResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetBrandsResponse>> CreateBrands(BrandsRequest request)
        {
            return await PostResource<GetBrandsResponse>($"{Endpoints.ONELOGIN_BRANDING}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to modify an existing Account Brand configuration.
        /// This endpoint accepts a partial payload but only updates the provided values.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="GetBrandsResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<GetBrandsResponse>> UpdateBrands(int brandId, BrandsRequest request)
        {
            return await PutResource<GetBrandsResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to delete an Account Brand.
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveBrands(int brandId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}", Endpoints.BaseApiVersion2);
        }
        #endregion Brands

        #region Error Custom Messages

        /// <summary>
        /// Use this API to get the acceptable languages for custom error message.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object..</param>
        /// <returns></returns>
        public async Task<ApiResponse<List<CustomErrorMessageLanguagesResponse>>> ListErrorMessageLanguages(long brandId)
        {
            return await GetResource<List<CustomErrorMessageLanguagesResponse>>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/{Endpoints.ONELOGIN_CUSTOM_ERROR_MESSAGES}/languages", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to lookup the custom error message. At this time, it is not possible to create a new custom message, only to modify existing messages.
        /// </summary>
        /// <param name="request"></param>        
        /// <returns>Returns the serialized <see cref="BrandingLookupMessagesResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<BrandingLookupMessagesResponse>> LookupCustomMessage(BrandingLookupMessagesRequest request)
        {
            return await PostResource<BrandingLookupMessagesResponse>($"branding/custom_error_message", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to lookup the custom error message. At this time, it is not possible to create a new custom message, only to modify existing messages.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object..</param>
        /// <param name="request"></param>        
        /// <returns>Returns the serialized <see cref="BrandingLookupMessagesResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<BrandingLookupMessagesResponse>> ListCustomMessage(long brandId,BrandingLookupMessagesRequest request)
        {
            return await PostResource<BrandingLookupMessagesResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/{Endpoints.ONELOGIN_CUSTOM_ERROR_MESSAGES}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to update a custom error message. At this time, it is not possible to create a new custom message, only to modify existing messages.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object..</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="BrandingUpdateLookupMessagesResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<BrandingUpdateLookupMessagesResponse>> UpdateCustomMessage(long brandId, BrandingUpdateLookupMessagesResponse request)
        {
            return await PutResource<BrandingUpdateLookupMessagesResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/{Endpoints.ONELOGIN_CUSTOM_ERROR_MESSAGES}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to delete a custom error message.
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <param name="messageId">Unique identifier for the custom error message.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveCustomMessage(long brandId,long messageId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/{Endpoints.ONELOGIN_CUSTOM_ERROR_MESSAGES}/{messageId}", Endpoints.BaseApiVersion2);
        }
        #endregion Error Custom Messages

        #region Message Template
        /// <summary>
        /// Use this API to return a list of message templates.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <returns>Returns the serialized <see cref="BrandingMessageTemplateResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<List<BrandingMessageTemplateResponse>>> ListMessageTemplates(long brandId)
        {
            return await GetResource<List<BrandingMessageTemplateResponse>>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/templates", Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to retrieve a single message template.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <param name="templateId">Unique identifier for the template to return.</param>
        /// <returns></returns>
        public async Task<ApiResponse<BrandingMessageTemplateResponse>> GetMessageTemplates(long brandId,long templateId)
        {
            return await GetResource<BrandingMessageTemplateResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/templates/{templateId}", Endpoints.BaseApiVersion2);

        }

        /// <summary>
        /// Use this API to retrieve a single message template by its type.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <param name="templateType">The message template type to return.</param>
        /// <returns></returns>
        public async Task<ApiResponse<BrandingMessageTemplateTypeResponse>> GetMessageTemplateTypes(long brandId, string templateType)
        {
            return await GetResource<BrandingMessageTemplateTypeResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/templates/{templateType}", Endpoints.BaseApiVersion2);

        }

        /// <summary>
        /// Use this API to retrieve a single message template by its type and language locale.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <param name="templateType">The message template type to return.</param>
        /// <param name="locale">The 2 character language locale for the template.</param>
        /// <returns></returns>
        public async Task<ApiResponse<BrandingMessageTemplateResponse>> GetMessageTemplateTypeAndLocale(long brandId, string templateType,string locale)
        {
            return await GetResource<BrandingMessageTemplateResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/templates/{templateType}/{locale}", Endpoints.BaseApiVersion2);

        }

        /// <summary>
        /// Use this API to retrieve a single default/master message template by its type.
        /// </summary>
        /// <param name="templateType">The message template type to return.</param>
        /// <returns></returns>
        public async Task<ApiResponse<BrandingMessageTemplateTypeResponse>> GetMessageMasterTemplateType(string templateType)
        {
            return await GetResource<BrandingMessageTemplateTypeResponse>($"{Endpoints.ONELOGIN_BRANDING}/master/templates/{templateType}", Endpoints.BaseApiVersion2);

        }

        /// <summary>
        /// Use this API to retrieve a single default/master message template by its type and language locale.
        /// </summary>
        /// <param name="templateType">The message template type to return.</param>
        /// <param name="locale">The 2 character language locale for the template.</param>
        /// <returns></returns>
        public async Task<ApiResponse<BrandingMessageTemplateTypeResponse>> GetMessageMasterTemplateTypeAndLocale( string templateType, string locale)
        {
            return await GetResource<BrandingMessageTemplateTypeResponse>($"{Endpoints.ONELOGIN_BRANDING}/master/templates/{templateType}/{locale}", Endpoints.BaseApiVersion2);

        }

        /// <summary>
        /// Use this API to create a new message template for a brand.
        /// Templates can be created in multiple languages and are used for customizing the content in Email and SMS notifications..
        /// </summary>
        /// <param name="request"></param>        
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <returns>Returns the serialized <see cref="BrandingMessageTemplateResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<BrandingMessageTemplateResponse>> CreateMessageTemplates(long brandId, BrandingMessageTemplateRequest request)
        {
            return await PostResource<BrandingMessageTemplateResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/templates", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to modify an existing Account Brand configuration.
        /// This endpoint accepts a partial payload but only updates the provided values.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="BrandingMessageTemplateResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<BrandingMessageTemplateResponse>> UpdateMessageTemplates(long brandId, long templateId, BrandingMessageTemplateRequest request)
        {
            return await PutResource<BrandingMessageTemplateResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/templates/{templateId}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to modify an existing Account Brand configuration.
        /// This endpoint accepts a partial payload but only updates the provided values.
        /// </summary>
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <param name="templateType">The message template type to return.</param>
        /// <param name="locale">The 2 character language locale for the template.</param>
        /// <param name="request"></param>
        /// <returns>Returns the serialized <see cref="BrandingMessageTemplateResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<BrandingMessageTemplateResponse>> UpdateMessageTemplatesTypeAndLocale(int brandId,string templateType,string locale, BrandsTemplateTypeRequest request)
        {
            return await PutResource<BrandingMessageTemplateResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/templates/{templateType}/{locale}", request, Endpoints.BaseApiVersion2);
        }

        /// <summary>
        /// Use this API to delete an Account Brand.
        /// <param name="brandId">Unique identifier for the branding object.</param>
        /// <returns>Returns the serialized <see cref="EmptyResponse"/> as an asynchronous operation.</returns>
        public async Task<ApiResponse<EmptyResponse>> RemoveMessageTemplates(int brandId, long templateId)
        {
            return await DeleteResource<EmptyResponse>($"{Endpoints.ONELOGIN_BRANDING}/{brandId}/templates/{templateId}", Endpoints.BaseApiVersion2);
        }
        #endregion Message Template

    }
}
