# AWS_Sample0_CreateS3Bucket

https://docs.aws.amazon.com/sdk-for-net/?icmpid=docs_homepage_sdktoolkits

https://github.com/awsdocs/aws-doc-sdk-examples/tree/main/dotnetv3/S3

```csharp
﻿using Amazon.S3;
using Amazon.S3.Model;

IAmazonS3 client = new AmazonS3Client();

var request = new PutBucketRequest
{
    BucketName = "luiscocoenriquezbucket",
    UseClientRegion = true,
};

var response = await client.PutBucketAsync(request);
```
