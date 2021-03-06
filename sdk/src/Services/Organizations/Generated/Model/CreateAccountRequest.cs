/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccount operation.
    /// Creates an AWS account that is automatically a member of the organization whose credentials
    /// made the request. This is an asynchronous request that AWS performs in the background.
    /// If you want to check the status of the request later, you need the <code>OperationId</code>
    /// response element from this operation to provide as a parameter to the <a>DescribeCreateAccountStatus</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// AWS Organizations preconfigures the new member account with a role (named <code>OrganizationAccountAccessRole</code>
    /// by default) that grants administrator permissions to the new account. Principals in
    /// the master account can assume the role. AWS Organizations clones the company name
    /// and address information for the new account from the organization's master account.
    /// </para>
    ///  
    /// <para>
    /// For more information about creating accounts, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_create.html">Creating
    /// an AWS Account in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// When you create an account in an organization using the AWS Organizations console,
    /// API, or CLI commands, the information required for the account to operate as a standalone
    /// account, such as a payment method and signing the End User Licence Agreement (EULA)
    /// is <i>not</i> automatically collected. If you must remove an account from your organization
    /// later, you can do so only after you provide the missing information. Follow the steps
    /// at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
    /// To leave an organization when all required account information has not yet been provided</a>
    /// in the <i>AWS Organizations User Guide</i>.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// When you create a member account with this operation, you can choose whether to create
    /// the account with the <b>IAM User and Role Access to Billing Information</b> switch
    /// enabled. If you enable it, IAM users and roles that have appropriate permissions can
    /// view billing information for the account. If you disable this, then only the account
    /// root user can access billing information. For information about how to disable this
    /// for an account, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html">Granting
    /// Access to Your Billing Information and Tools</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation can be called only from the organization's master account.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you get an exception that indicates that you exceeded your account limits for the
    /// organization or that you can"t add an account because your organization is still initializing,
    /// please contact <a href="https://console.aws.amazon.com/support/home#/"> AWS Customer
    /// Support</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateAccountRequest : AmazonOrganizationsRequest
    {
        private string _accountName;
        private string _email;
        private IAMUserAccessToBilling _iamUserAccessToBilling;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The friendly name of the member account.
        /// </para>
        /// </summary>
        public string AccountName
        {
            get { return this._accountName; }
            set { this._accountName = value; }
        }

        // Check to see if AccountName property is set
        internal bool IsSetAccountName()
        {
            return this._accountName != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the owner to assign to the new member account. This email address
        /// must not already be associated with another AWS account. You must use a valid email
        /// address to complete account creation. You cannot access the root user of the account
        /// or remove an account that was created with an invalid email address.
        /// </para>
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property IamUserAccessToBilling. 
        /// <para>
        /// If set to <code>ALLOW</code>, the new account enables IAM users to access account
        /// billing information <i>if</i> they have the required permissions. If set to <code>DENY</code>,
        /// then only the root user of the new account can access account billing information.
        /// For more information, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html#ControllingAccessWebsite-Activate">Activating
        /// Access to the Billing and Cost Management Console</a> in the <i>AWS Billing and Cost
        /// Management User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify this parameter, the value defaults to ALLOW, and IAM users and
        /// roles with the required permissions can access billing information for the new account.
        /// </para>
        /// </summary>
        public IAMUserAccessToBilling IamUserAccessToBilling
        {
            get { return this._iamUserAccessToBilling; }
            set { this._iamUserAccessToBilling = value; }
        }

        // Check to see if IamUserAccessToBilling property is set
        internal bool IsSetIamUserAccessToBilling()
        {
            return this._iamUserAccessToBilling != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// (Optional)
        /// </para>
        ///  
        /// <para>
        /// The name of an IAM role that Organizations automatically preconfigures in the new
        /// member account. This role trusts the master account, allowing users in the master
        /// account to assume the role, as permitted by the master account administrator. The
        /// role has administrator permissions in the new member account.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify this parameter, the role name defaults to <code>OrganizationAccountAccessRole</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to use this role to access the member account, see
        /// <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_access.html#orgs_manage_accounts_create-cross-account-role">Accessing
        /// and Administering the Member Accounts in Your Organization</a> in the <i>AWS Organizations
        /// User Guide</i>, and steps 2 and 3 in <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/tutorial_cross-account-with-roles.html">Tutorial:
        /// Delegate Access Across AWS Accounts Using IAM Roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> that is used to validate
        /// this parameter is a string of characters that can consist of uppercase letters, lowercase
        /// letters, digits with no spaces, and any of the following characters: =,.@-
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}