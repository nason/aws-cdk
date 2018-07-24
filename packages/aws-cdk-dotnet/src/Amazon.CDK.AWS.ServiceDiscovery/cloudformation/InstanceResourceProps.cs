using Amazon.CDK;
using AWS.Jsii.Runtime.Deputy;
using Newtonsoft.Json.Linq;

namespace Amazon.CDK.AWS.ServiceDiscovery.cloudformation
{
    /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html </remarks>
    public class InstanceResourceProps : DeputyBase, IInstanceResourceProps
    {
        /// <summary>``AWS::ServiceDiscovery::Instance.InstanceAttributes``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-instanceattributes </remarks>
        [JsiiProperty("instanceAttributes", "{\"union\":{\"types\":[{\"primitive\":\"json\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object InstanceAttributes
        {
            get;
            set;
        }

        /// <summary>``AWS::ServiceDiscovery::Instance.ServiceId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-serviceid </remarks>
        [JsiiProperty("serviceId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]}}", true)]
        public object ServiceId
        {
            get;
            set;
        }

        /// <summary>``AWS::ServiceDiscovery::Instance.InstanceId``</summary>
        /// <remarks>link: http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-instanceid </remarks>
        [JsiiProperty("instanceId", "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"@aws-cdk/cdk.Token\"}]},\"optional\":true}", true)]
        public object InstanceId
        {
            get;
            set;
        }
    }
}