namespace CompraVendaApi.Classes
{
    public class Enums
    {
        public enum TagCode
        {
            /// <summary>
            /// Invalid entity
            /// </summary>
            OtherException = 0,

            /// <summary>
            /// Item created successfully
            /// </summary>
            SuccessCreate = 1,

            /// <summary>
            /// Item updated successfully
            /// </summary>
            SuccessUpdate = 2,

            /// <summary>
            /// Nonexistent Node NODE_ID
            /// </summary>
            NotFoundNode = 3,

            /// <summary>
            /// Nonexistent Entity _ID
            /// </summary>
            NotFoundID = 4,

            /// <summary>
            /// _ID already exists!
            /// </summary>
            DuplicateID = 5,

            /// <summary>
            /// CODE already exists!
            /// </summary>
            DuplicateCode = 6,

            /// <summary>
            /// DESIGNATION_NATIVE already exists
            /// </summary>
            DuplicateDesignation = 7,

            /// <summary>
            /// Error when trying to create _ID
            /// </summary>
            CreateIDError = 8,

            /// <summary>
            /// Check if MinimumStock >= 0 and ReorderQuantity >= MinimumStock
            /// </summary>
            ErrorMinimumStock = 9,


            /// <summary>
            /// Invalid entity
            /// </summary>
            InvalidEntity = 10,

            /// <summary>
            /// Invalid entity
            /// </summary>
            InvalidModel = 11,

            /// <summary>
            ///Exception thrown by DbContext when it was expected that SaveChanges for an entity would result
            ///in a database update but in fact no rows in the database were affected. This usually indicates
            ///that the database has been concurrently updated such that a concurrency token that was expected
            ///to match did not actually match. Note that state entries referenced by this exception are not
            ///serialized due to security and accesses to the state entries after serialization will return null.
            /// </summary>
            DbUpdateConcurrencyException = 12,

            /// <summary>
            /// Invalid entity
            /// </summary>
            EmptyResult = 13,

            /// <summary>
            /// Cannot Delete
            /// </summary>
            CanNotDelete = 14,

            /// <summary>
            /// User item found successfully
            /// </summary>
            SuccessUser = 15,

            //Login User not found (for AccountController)
            UserNotFound = 16,

            /// <summary>
            /// Existing password when user tries to update password
            /// </summary>
            Existingpassword = 17,

            /// <summary>
            /// Not enough stock (used in CustomerInvoice)
            /// </summary>
            NotEnoughStock = 18,

            /// <summary>
            /// Exception for using a key that is already being used.
            /// </summary>
            DuplicateKeyException = 19,

            /// <summary>
            /// Exception Operations that were already done
            /// </summary>
            OperationAlreadyDone = 20,

            TechnicalError = 21,

            /// <summary>
            /// Exception Hash Missing
            /// </summary>
            MissingHash = 22,

            /// <summary>
            /// Exception for database update error
            /// </summary>
            DBUpdateException = 23,

            ///<summary>
            /// Exception for Invalid Advance Invoice Value
            /// </summary>
            InvalidAdvance = 95,

            ///<summary>
            /// Exception for Invalid Parent Account Type "Conta Invalida, 
            /// A conta acima não pode ser integradora porque ja tem movimentos associados"
            /// </summary>
            COAInvalidParentAccountCode = 96,

            ///<summary>
            /// Exception for Invalid Parent Account Type "Conta Invalida, 
            /// A conta do nivel acima não pode ser uma conta que movimenta terceiros"
            /// </summary>
            COAInvalidParentAccountThirdParty = 97,

            ///<summary>
            /// Exception for Account Code Already Exist
            /// </summary>
            COAAccountCodeAlreadyExist = 98,

            ///<summary>
            /// Exception for Account Code Already Has Movements
            /// </summary>
            COAAccountAlreadyHasMovements = 99,

            ///<summary>
            /// Exception for Account Restriction Cannot Be Set To Credit because there are debit movements
            /// </summary>
            COAAccountRestrictionDebitConflict = 100,

            ///<summary>
            /// Exception for Account Restriction Cannot Be Set To Debit because there are credit movements
            /// </summary>
            COAAccountRestrictionCreditConflict = 101,

            ///<summary>
            /// Exception for duplicate supplier reference
            /// </summary>
            SupplierReferenceAlreadyExists = 102,
            DocumentAlreadySaved = 103,

            OopsMessageNotFound = 1000
        }

        public enum StatusCode
        {
            #region - 1xx Informational -

            /// <summary>
            /// Continue indicates that the client can continue with its request.
            /// </summary>
            Continue = 100,

            /// <summary>
            /// SwitchingProtocols indicates that the protocol version or protocol is being changed.
            /// </summary>
            SwitchingProtocols = 101,

            #endregion - 1xx Informational -

            #region - 2xx Success -

            /// <summary>
            /// OK indicates that the request succeeded and that the requested information is in the response. This is the most common status code to receive.
            /// </summary>
            OK = 200,
            /// <summary>
            /// Created indicates that the request resulted in a new resource created before the response was sent.
            /// </summary>
            Created = 201,
            /// <summary>
            /// Accepted indicates that the request has been accepted for further processing.
            /// </summary>
            Accepted = 202,
            /// <summary>
            /// NonAuthoritativeInformation indicates that the returned metainformation is from a cached copy instead of the origin server and therefore may be incorrect.
            /// </summary>
            NonAuthoritativeInformation = 203,
            /// <summary>
            /// NoContent indicates that the request has been successfully processed and that the response is intentionally blank.
            /// </summary>
            NoContent = 204,
            /// <summary>
            /// ResetContent indicates that the client should reset (not reload) the current resource.
            /// </summary>
            ResetContent = 205,
            /// <summary>
            /// PartialContent indicates that the response is a partial response as requested by a GET request that includes a byte range.
            /// </summary>
            PartialContent = 206,

            #endregion - 2xx Success -

            #region - 3xx Redirection -
            /// <summary>
            /// Ambiguous indicates that the requested information has multiple representations. 
            /// The default action is to treat this status as a redirect and follow the contents of the Location header associated with this response.
            /// </summary>
            Ambiguous = 300,
            /// <summary>
            /// Moved indicates that the requested information has been moved to the URI specified in the Location header. 
            /// The default action when this status is received is to follow the Location header associated with the response. 
            /// When the original request method was POST, the redirected request will use the 
            Moved = 301,
            /// <summary>
            /// Found indicates that the requested information is located at the URI specified in the Location header. 
            /// The default action when this status is received is to follow the Location header associated with the response. 
            /// When the original request method was POST, the redirected request will use the GET method.
            /// </summary>
            Found = 302,
            /// <summary>
            /// RedirectMethod automatically redirects the client to the URI specified in the Location header as the result of a POST. 
            /// The request to the resource specified by the Location header will be made with a GET.
            /// </summary>
            RedirectMethod = 303,
            /// <summary>
            /// NotModified indicates that the client's cached copy is up to date. The contents of the resource are not transferred.
            /// </summary>
            NotModified = 304,
            /// <summary>
            /// UseProxy indicates that the request should use the proxy server at the URI specified in the Location header.
            /// </summary>
            UseProxy = 305,
            /// <summary>
            /// Unused is a proposed extension to the HTTP/1.1 specification that is not fully specified.
            /// </summary>
            Unused = 306,
            /// <summary>
            /// RedirectKeepVerb indicates that the request information is located at the URI specified in the Location header. 
            /// The default action when this status is received is to follow the Location header associated with the response. 
            /// When the original request method was POST, the redirected request will also use the POST method.
            /// </summary>
            RedirectKeepVerb = 307,

            #endregion - 3xx Redirection -

            #region - 4xx Client Error -
            /// <summary>
            /// BadRequest indicates that the request could not be understood by the server. 
            /// BadRequest is sent when no other error is applicable, or if the exact error is unknown or does not have its own error code.
            /// </summary>
            BadRequest = 400,
            /// <summary>
            /// Unauthorized indicates that the requested resource requires authentication. The WWW-Authenticate header contains the details of how to perform the authentication.
            /// </summary>
            Unauthorized = 401,
            /// <summary>
            /// PaymentRequired is reserved for future use.
            PaymentRequired = 402,
            /// <summary>
            /// Forbidden indicates that the server refuses to fulfill the request.
            /// </summary>
            Forbidden = 403,
            /// <summary>
            /// NotFound indicates that the requested resource does not exist on the server.
            NotFound = 404,
            /// <summary>
            /// MethodNotAllowed indicates that the request method (POST or GET) is not allowed on the requested resource.
            /// </summary>
            MethodNotAllowed = 405,
            /// <summary>
            /// NotAcceptable indicates that the client has indicated with Accept headers that it will not accept any of the available representations of the resource.
            /// </summary>
            NotAcceptable = 406,
            /// <summary>
            /// ProxyAuthenticationRequired indicates that the requested proxy requires authentication. 
            /// The Proxy-authenticate header contains the details of how to perform the authentication.
            ProxyAuthenticationRequired = 407,
            /// <summary>
            /// RequestTimeout indicates that the client did not send a request within the time the server was expecting the request.
            /// </summary>
            RequestTimeout = 408,
            /// <summary>
            /// Conflict indicates that the request could not be carried out because of a conflict on the server.
            /// </summary>
            Conflict = 409,
            /// <summary>
            /// Gone indicates that the requested resource is no longer available.
            /// </summary>
            Gone = 410,
            /// <summary>
            /// LengthRequired indicates that the required Content-length header is missing.
            /// </summary>
            LengthRequired = 411,
            /// <summary>
            /// PreconditionFailed indicates that a condition set for this request failed, and the request cannot be carried out. 
            /// Conditions are set with conditional request headers like If-Match, If-None-Match, or If-Unmodified-Since.
            /// </summary>
            PreconditionFailed = 412,
            /// <summary>
            /// RequestEntityTooLarge indicates that the request is too large for the server to process.
            /// </summary>
            RequestEntityTooLarge = 413,
            /// <summary>
            /// RequestUriTooLong indicates that the URI is too long.
            /// </summary>
            RequestUriTooLong = 414,
            /// <summary>
            /// UnsupportedMediaType indicates that the request is an unsupported type.
            UnsupportedMediaType = 415,
            /// <summary>
            /// RequestedRangeNotSatisfiable indicates that the range of data requested from the resource cannot be returned, 
            /// either because the beginning of the range is before the beginning of the resource, or the end of the range is after the end of the resource.
            /// </summary>
            RequestedRangeNotSatisfiable = 416,
            /// <summary>
            /// ExpectationFailed indicates that an expectation given in an Expect header could not be met by the server.
            /// </summary>
            ExpectationFailed = 417,
            /// <summary>
            /// UpgradeRequired indicates that the client should switch to a different protocol such as TLS/1.0.
            /// </summary>

            #endregion - 4xx Client Error -

            #region - 5xx Server Error -
            /// <summary>
            /// InternalServerError indicates that a generic error has occurred on the server.
            /// </summary>
            InternalServerError = 500,
            /// <summary>
            /// NotImplemented indicates that the server does not support the requested function.
            /// </summary>
            NotImplemented = 501,
            /// <summary>
            /// BadGateway indicates that an intermediate proxy server received a bad response from another proxy or the origin server.
            /// </summary>
            BadGateway = 502,
            /// <summary>
            /// ServiceUnavailable indicates that the server is temporarily unavailable, usually due to high load or maintenance.
            /// </summary>
            ServiceUnavailable = 503,
            /// <summary>
            /// GatewayTimeout indicates that an intermediate proxy server timed out while waiting for a response from another proxy or the origin server.
            /// </summary>
            GatewayTimeout = 504,
            /// <summary>
            /// HttpVersionNotSupported indicates that the requested HTTP version is not supported by the server.
            /// </summary>
            HttpVersionNotSupported = 505,

            #endregion
        };
    }
}
