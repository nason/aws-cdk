using Amazon.CDK;
using Amazon.CDK.AWS.Serverless.cloudformation.FunctionResource;
using AWS.Jsii.Runtime.Deputy;
using System.Collections.Generic;

namespace Amazon.CDK.AWS.Serverless.cloudformation
{
    /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
    [JsiiInterface(typeof(IFunctionResourceProps), "@aws-cdk/aws-serverless.cloudformation.FunctionResourceProps")]
    public interface IFunctionResourceProps
    {
        /// <summary>``AWS::Serverless::Function.CodeUri``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("codeUri", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-serverless.cloudformation.FunctionResource.S3LocationProperty\"}]}}")]
        object CodeUri
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.Handler``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("handler", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Handler
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.Runtime``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("runtime", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}")]
        object Runtime
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.DeadLetterQueue``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("deadLetterQueue", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-serverless.cloudformation.FunctionResource.DeadLetterQueueProperty\"}]},\"optional\":true}")]
        object DeadLetterQueue
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.Description``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("description", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object Description
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.Environment``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("environment", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-serverless.cloudformation.FunctionResource.FunctionEnvironmentProperty\"}]},\"optional\":true}")]
        object Environment
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.Events``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("events", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-serverless.cloudformation.FunctionResource.EventSourceProperty\"}]}}}}]},\"optional\":true}")]
        object Events
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.FunctionName``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("functionName", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object FunctionName
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.KmsKeyArn``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("kmsKeyArn", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.MemorySize``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("memorySize", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object MemorySize
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.Policies``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("policies", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-serverless.cloudformation.FunctionResource.IAMPolicyDocumentProperty\"},{\"collection\":{\"kind\":\"array\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-serverless.cloudformation.FunctionResource.IAMPolicyDocumentProperty\"}]}}}}]},\"optional\":true}")]
        object Policies
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.Role``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("role", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object Role
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.Tags``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("tags", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"collection\":{\"kind\":\"map\",\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}}}]},\"optional\":true}")]
        object Tags
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.Timeout``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("timeout", "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object Timeout
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.Tracing``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("tracing", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}")]
        object Tracing
        {
            get;
            set;
        }

        /// <summary>``AWS::Serverless::Function.VpcConfig``</summary>
        /// <remarks>link: https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#awsserverlessfunction </remarks>
        [JsiiProperty("vpcConfig", "{\"union\":{\"types\":[{\"fqn\":\"@aws-cdk/cdk.Token\"},{\"fqn\":\"@aws-cdk/aws-serverless.cloudformation.FunctionResource.VpcConfigProperty\"}]},\"optional\":true}")]
        object VpcConfig
        {
            get;
            set;
        }
    }
}