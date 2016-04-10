﻿using System.Collections.Generic;

namespace XCLCMS.Data.BLL
{
    /// <summary>
    /// 文章表
    /// </summary>
    public partial class Article
    {
        private readonly XCLCMS.Data.DAL.Article dal = new XCLCMS.Data.DAL.Article();

        public Article()
        { }

        #region BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(XCLCMS.Data.Model.Article model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(XCLCMS.Data.Model.Article model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XCLCMS.Data.Model.Article GetModel(long ArticleID)
        {
            return dal.GetModel(ArticleID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<XCLCMS.Data.Model.Article> GetModelList(string strWhere)
        {
            return dal.GetModelList(strWhere);
        }

        #endregion BasicMethod

        #region ExtensionMethod

        /// <summary>
        /// 分页列表
        /// </summary>
        public List<XCLCMS.Data.Model.Article> GetPageList(XCLNetTools.Entity.PagerInfo pageInfo, string strWhere, string fieldName, string fieldKey, string fieldOrder)
        {
            return dal.GetPageList(pageInfo, strWhere, fieldName, fieldKey, fieldOrder);
        }

        /// <summary>
        /// 获取文章类型
        /// </summary>
        public Dictionary<string, long> GetArticleTypeDic()
        {
            return new XCLCMS.Data.BLL.SysDic().GetDictionaryByCodeWithID(XCLCMS.Data.CommonHelper.SysDicConst.SysDicCodeEnum.ArticleType.ToString());
        }

        /// <summary>
        /// 判断指定code是否存在
        /// </summary>
        public bool IsExistCode(string code)
        {
            return dal.IsExistCode(code);
        }

        #endregion ExtensionMethod
    }
}