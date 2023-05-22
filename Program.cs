using Amazon.S3;
using Amazon.S3.Model;

IAmazonS3 client = new AmazonS3Client();

var request = new PutBucketRequest
{
    BucketName = "luiscocoenriquezbucket",
    UseClientRegion = true,
};

var response = await client.PutBucketAsync(request);

