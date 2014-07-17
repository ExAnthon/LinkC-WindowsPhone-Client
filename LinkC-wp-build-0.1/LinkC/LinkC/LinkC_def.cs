using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkC
{
    class LinkC_def
    {
    }
    /*  ========= 数据类型 ===========  */
    struct MessageHeader_t
    {             //  消息头
        Byte ActionType;         //  见 [操作类型]
        Byte ServiceType;        //  见 [服务数据]
        UInt16 StatusCode;         //  状态码
    };
    struct RequestUser_t{
    UInt32    UID;
    UInt32    Flag;
};

struct LoginData_t{                 //  登陆数据
        Char[] UserName = new char[16];
        Char[] PassWord = new char[16];
};

struct UserData_t{                  //  用户数据
    UInt32    UID;
    Byte     Status;             // 现在状态
    Char[]        NickName = new Char[21];       // 昵称
    Char[]        UserName = new Char[21];       // [登陆]用户名

    Byte     IsFriend;           //  是否为好友
    UInt16    GroupNumber;        //  属于哪一组的
    Char[]        PrivateNickName = new Char[21];//  你给对方取的昵称

    Char[]        Telephone = new Char[21];      // 电话
    Char[]        Company = new Char[21];        // 公司
    Char[]        Address = new Char[80];        // 地址
    Char[]        JoinTime = new Char[25];       // 创建时间
    UInt32    IP;                 // 现在IP地址
};

struct P2PInfo_t{
    struct sockaddr_in Dest;
    int is_server;
};

struct PthreadData_t{
    struct sockaddr_in  Addr;
    int                 Sockfd;
};

}
