  using System;
  using System.Collections.Generic;
  using Swagger.Client.Common;
  using Swagger.Client.Model;
  namespace Swagger.Client.Api {
    public class ApiApi {
      string basePath;
      private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

      public ApiApi(String basePath = "http://localhost:9000")
      {
        this.basePath = basePath;
      }

      public ApiInvoker getInvoker() {
        return apiInvoker;
      }

      // Sets the endpoint base url for the services being accessed
      public void setBasePath(string basePath) {
        this.basePath = basePath;
      }

      // Gets the endpoint base url for the services being accessed
      public String getBasePath() {
        return basePath;
      }

      /// <summary>
      /// In this method, one can create a refund for an existing Subscription 
      /// </summary>
      /// <param name="body">The refund representation in JSON of the refund to be created</param>
      /// <returns></returns>
      public void POST_controllers_api_Refunds$_createRefund (RefundBean body) {
        // create path and map variables
        var path = "/api/refunds/{subsExtId}".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        try {
          if (typeof(void) == typeof(byte[])) {
            var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
            return ;
          } else {
            var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return ;
            }
            else {
              return ;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return ;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// This method creates a new Client 
      /// </summary>
      /// <param name="body">The client representation in JSON of the client to be created</param>
      /// <returns></returns>
      public void POST_controllers_api_Clients$_create (Client body) {
        // create path and map variables
        var path = "/api/clients".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        try {
          if (typeof(void) == typeof(byte[])) {
            var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
            return ;
          } else {
            var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return ;
            }
            else {
              return ;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return ;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// It creates multiple new Clients from a JSON array 
      /// </summary>
      /// <param name="body">The client representation in JSON of the client to be created</param>
      /// <returns></returns>
      public void POST_controllers_api_Clients$_createFromArray (Client body) {
        // create path and map variables
        var path = "/api/clients/jsonArray".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        try {
          if (typeof(void) == typeof(byte[])) {
            var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
            return ;
          } else {
            var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return ;
            }
            else {
              return ;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return ;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// This method creates a new Plan 
      /// </summary>
      /// <param name="body">The plan representation in JSON of the plan to be created</param>
      /// <returns></returns>
      public void POST_controllers_api_Plans$_create (Plan body) {
        // create path and map variables
        var path = "/api/plans".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        try {
          if (typeof(void) == typeof(byte[])) {
            var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
            return ;
          } else {
            var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return ;
            }
            else {
              return ;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return ;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// This method creates multiple new Plans in a batch 
      /// </summary>
      /// <param name="body">The plan representation in JSON of the plan to be created</param>
      /// <returns></returns>
      public void POST_controllers_api_Plans$_createFromArray (Plan body) {
        // create path and map variables
        var path = "/api/plans/jsonArray".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        try {
          if (typeof(void) == typeof(byte[])) {
            var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
            return ;
          } else {
            var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return ;
            }
            else {
              return ;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return ;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// This method changes the status of an already created subscription 
      /// </summary>
      /// <param name="body">The subscription status representation in JSON of the new status</param>
      /// <returns></returns>
      public void PUT_controllers_api_Subscriptions$_changeStatus (SubscriptionStatusChange body) {
        // create path and map variables
        var path = "/api/subscriptions/{extId}".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        try {
          if (typeof(void) == typeof(byte[])) {
            var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
            return ;
          } else {
            var response = apiInvoker.invokeAPI(basePath, path, "PUT", queryParams, body, headerParams, formParams);
            if(response != null){
               return ;
            }
            else {
              return ;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return ;
          }
          else {
            throw ex;
          }
        }
      }
      /// <summary>
      /// This method creates a new Subscription 
      /// </summary>
      /// <param name="body">The subscription representation in JSON of the subscription to be created</param>
      /// <returns></returns>
      public void POST_controllers_api_Subscriptions$_createSubscription (Subscription body) {
        // create path and map variables
        var path = "/api/subscriptions".Replace("{format}","json");

        // query params
        var queryParams = new Dictionary<String, String>();
        var headerParams = new Dictionary<String, String>();
        var formParams = new Dictionary<String, object>();

        // verify required params are set
        if (body == null ) {
           throw new ApiException(400, "missing required params");
        }
        try {
          if (typeof(void) == typeof(byte[])) {
            var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams);
            return ;
          } else {
            var response = apiInvoker.invokeAPI(basePath, path, "POST", queryParams, body, headerParams, formParams);
            if(response != null){
               return ;
            }
            else {
              return ;
            }
          }
        } catch (ApiException ex) {
          if(ex.ErrorCode == 404) {
          	return ;
          }
          else {
            throw ex;
          }
        }
      }
      }
    }
