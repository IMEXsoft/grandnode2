﻿using Grand.Domain.Knowledgebase;
using Grand.Web.Admin.Models.Knowledgebase;

namespace Grand.Web.Admin.Interfaces;

public interface IKnowledgebaseViewModelService
{
    Task<List<TreeNode>> PrepareTreeNode();
    Task PrepareCategory(KnowledgebaseCategoryModel model);
    Task PrepareCategory(KnowledgebaseArticleModel model);

    Task<(IEnumerable<KnowledgebaseArticleGridModel> knowledgebaseArticleGridModels, int totalCount)>
        PrepareKnowledgebaseArticleGridModel(string parentCategoryId, int pageIndex, int pageSize);

    Task<KnowledgebaseCategoryModel> PrepareKnowledgebaseCategoryModel();
    Task<KnowledgebaseCategory> InsertKnowledgebaseCategoryModel(KnowledgebaseCategoryModel model);

    Task<KnowledgebaseCategory> UpdateKnowledgebaseCategoryModel(KnowledgebaseCategory knowledgebaseCategory,
        KnowledgebaseCategoryModel model);

    Task DeleteKnowledgebaseCategoryModel(KnowledgebaseCategory knowledgebaseCategory);
    Task<KnowledgebaseArticleModel> PrepareKnowledgebaseArticleModel();
    Task<KnowledgebaseArticle> InsertKnowledgebaseArticleModel(KnowledgebaseArticleModel model);

    Task<KnowledgebaseArticle> UpdateKnowledgebaseArticleModel(KnowledgebaseArticle knowledgebaseArticle,
        KnowledgebaseArticleModel model);

    Task DeleteKnowledgebaseArticle(KnowledgebaseArticle knowledgebaseArticle);
    Task InsertKnowledgebaseRelatedArticle(KnowledgebaseArticleModel.AddRelatedArticleModel model);
    Task DeleteKnowledgebaseRelatedArticle(KnowledgebaseArticleModel.AddRelatedArticleModel model);
}